using CourseraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Data
{
    public class CourseRepository
    {
        private readonly CourseraDbContext _context;

        public CourseRepository(CourseraDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAllCourses() => _context.Courses.ToList();

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == id);

            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}
