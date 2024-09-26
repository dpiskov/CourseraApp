using CourseraApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseraApp.Data
{
    public class CourseraDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=ASUS;Database=CourseraApp;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
