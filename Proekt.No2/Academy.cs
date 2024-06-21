using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.No2
{
    internal class Academy
    {
        private string name;
        private List<Course> courses;
        private List<Students> enrolledStudents;

        public Academy(string name)
        {
            this.name = name;
            this.courses = new List<Course>();
            this.enrolledStudents = new List<Students>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public List<Students> EnrolledStudents
        {
            get
            {
                return this.enrolledStudents;
            }
            set
            {
                this.enrolledStudents = value;
            }
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void AddStudent(Students student)
        {
            enrolledStudents.Add(student);
        }

        public void PrintAcademyData()
        {
            Console.WriteLine($"Academy: {Name}");
            Console.WriteLine("Students and their courses:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"- {student.Name}:");
                foreach (var course in student.EnrolledCourses)
                {
                    Console.WriteLine($" - {course.CourseName}");
                }
            }

            Console.WriteLine("Courses with no enrolled students:");
            var coursesWithNoStudents = Courses.Where(w => w.EnrolledStudents.Count == 0).Select(w => w.CourseName);
            foreach (var courseName in coursesWithNoStudents)
            {
                Console.WriteLine($"- {courseName}");
            }
        }
    }
}
