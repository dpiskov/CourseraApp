using CourseraApp.Data;
using CourseraApp.Models;
using CourseraApp.Services;

namespace CourseraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the context, repositories, and services
            CourseraDbContext context = new CourseraDbContext();
            InstructorRepository instructorRepo = new InstructorRepository(context);
            CourseRepository courseRepo = new CourseRepository(context);

            InstructorService instructorService = new InstructorService(instructorRepo);
            CourseService courseService = new CourseService(courseRepo);

            Console.WriteLine("Welcome to CourseraApp!");

            Console.WriteLine("1. Add an Instructor");
            Console.WriteLine("2. Add a Course");
            Console.WriteLine("3. List All Courses");
            Console.WriteLine("4. List All Instructors");

            Console.WriteLine("Enter your choice:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Instructor First Name:");
                    string instructorFirstName = Console.ReadLine();
                    Console.WriteLine("Enter Instructor Last Name:");
                    string instructorLastName = Console.ReadLine();
                    instructorService.AddInstructor(instructorFirstName, instructorLastName);
                    Console.WriteLine("Instructor added successfully!");
                    break;

                case "2":
                    Console.WriteLine("Enter Course Name:");
                    string courseName = Console.ReadLine();
                    Console.WriteLine("Enter Instructor ID:");
                    int instructorId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Total Time:");
                    int totalTime = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Credit:");
                    break;
            }
        }
    }
}
