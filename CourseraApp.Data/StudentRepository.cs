using CourseraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Data
{
    public class StudentRepository
    {
        private readonly CourseraDbContext _context;

        public StudentRepository(CourseraDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents() => _context.Students.ToList();

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
