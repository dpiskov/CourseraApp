
using CourseraApp.Data;
using CourseraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Services
{
    public class InstructorService
    {
        private readonly InstructorRepository _instructorRepository;

        public InstructorService(InstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public void AddInstructor(string firstName, string lastName)
        {
            Instructor instructor = new Instructor()
            {
                FirstName = firstName,
                LastName = lastName
            };

            _instructorRepository.AddInstructor(instructor);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructorRepository.GetAllInstructors();
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorRepository.GetInstructorById(id);
        }

        public void UpdateInstructor(int id, string firstName, string lastName)
        {
            var instructor = _instructorRepository.GetInstructorById(id);

            if (instructor != null)
            {
                instructor.FirstName = firstName;
                instructor.LastName = lastName;

                _instructorRepository.UpdateInstructor(instructor);
            }
        }

        public void DeleteInstructor(int id)
        {
            _instructorRepository.DeleteInstructor(id);
        }
    }
}
