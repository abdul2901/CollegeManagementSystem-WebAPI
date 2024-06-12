using Microsoft.EntityFrameworkCore;

namespace college1.Models
{
    public class college1DBContext : DbContext
    {
        public college1DBContext(DbContextOptions options) : base(options) { }

        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Faculty> faculty { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Registration> registration { get; set; }
            
    }
}
