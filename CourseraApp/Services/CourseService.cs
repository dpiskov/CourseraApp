using CourseraApp.Data;
using CourseraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseraApp.Services
{
    public class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void AddCourse(string name, int instructorId, int totalTime, int credit)
        {
            Course course = new Course
            {
                Name = name,
                InstructorId = instructorId,
                TotalTime = totalTime,
                Credit = credit,
                TimeCreated = DateTime.Now
            };

            _courseRepository.AddCourse(course);
        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetCourseById(id);
        }

        public void UpdateCourse(int id, string name, int instructorId, int totalTime, int credit)
        {
            var course = _courseRepository.GetCourseById(id);

            if (course != null)
            {
                course.Name = name;
                course.InstructorId = instructorId;
                course.TotalTime = totalTime;
                course.Credit = credit;

                _courseRepository.UpdateCourse(course);
            }
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }
    }
}
