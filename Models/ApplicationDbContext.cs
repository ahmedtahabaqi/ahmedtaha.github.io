using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options)
           : base(Options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
    }
}
