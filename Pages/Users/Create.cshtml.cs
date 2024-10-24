using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;
using RazorPages_RAD_Lab_5.Data;

namespace RazorPages_RAD_Lab_5.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly RazorPages_RAD_Lab_5.Data.RazorPages_RAD_Lab_5Context _context;

        public CreateModel(RazorPages_RAD_Lab_5.Data.RazorPages_RAD_Lab_5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
