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
    public class IndexModel : PageModel
    {
        private readonly RazorPages_RAD_Lab_5.Data.RazorPages_RAD_Lab_5Context _context;

        public IndexModel(RazorPages_RAD_Lab_5.Data.RazorPages_RAD_Lab_5Context context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
