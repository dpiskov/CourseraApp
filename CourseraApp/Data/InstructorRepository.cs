using CourseraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Data
{
    public class InstructorRepository
    {
        private readonly CourseraDbContext _context;

        public InstructorRepository(CourseraDbContext context)
        {
            _context = context;
        }

        public List<Instructor> GetAllInstructors() => _context.Instructors.ToList();

        public void AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.Id == id);
        }

        public void UpdateInstructor(Instructor instructor)
        {
            _context.Instructors.Update(instructor);
            _context.SaveChanges();
        }

        public void DeleteInstructor(int id)
        {
            var instructor = _context.Instructors.FirstOrDefault(i => i.Id == id);

            if (instructor != null)
            {
                {
                    _context.Instructors.Remove(instructor);
                    _context.SaveChanges();
                }
            }
        }
    }
}