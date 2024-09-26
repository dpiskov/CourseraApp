using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Models
{
    public class Student
    {
        public required string Pin { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime TimeCreated { get; set; }
        public List<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }
}
