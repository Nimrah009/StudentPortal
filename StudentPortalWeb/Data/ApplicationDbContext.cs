using Microsoft.EntityFrameworkCore;
using StudentPortalWeb.Models.Entities;

namespace StudentPortalWeb.Data
{
    // This Class is a "bridge" between my application and the database.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        
    }
}
