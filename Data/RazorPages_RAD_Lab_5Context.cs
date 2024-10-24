using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPages_RAD_Lab_5.Data
{
    public class RazorPages_RAD_Lab_5Context : DbContext
    {
        public RazorPages_RAD_Lab_5Context (DbContextOptions<RazorPages_RAD_Lab_5Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.User> User { get; set; } = default!;
    }
}
