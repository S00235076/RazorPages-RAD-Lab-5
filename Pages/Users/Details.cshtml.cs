using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPages_RAD_Lab_5.Data;

namespace RazorPages_RAD_Lab_5.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages_RAD_Lab_5.Data.RazorPages_RAD_Lab_5Context _context;

        public DetailsModel(RazorPages_RAD_Lab_5.Data.RazorPages_RAD_Lab_5Context context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
