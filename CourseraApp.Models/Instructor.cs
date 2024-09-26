using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime TimeCreated { get; set; }

        //public Instructor(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    TimeCreated = DateTime.Now;
        //}
        //public Instructor()
        //{
        //}
    }
}
