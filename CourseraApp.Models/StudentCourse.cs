using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Models
{
    public class StudentCourse
    {
        public required string StudentPin { get; set; }
        public int CourseId { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
