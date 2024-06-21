namespace Proekt.No2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the academy: ");
            string academyName = Console.ReadLine();
            Academy academy = new Academy(academyName);

            Console.Write("Enter the number of courses: ");
            int courseCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < courseCount; i++)
            {
                Console.Write($"Enter the name of course {i + 1}: ");
                string courseName = Console.ReadLine();
                Console.Write($"Enter the email of course {i + 1}: ");
                string courseEmail = Console.ReadLine();
                Course course = new Course(courseName, courseEmail);
                academy.AddCourse(course);
            }

            Console.Write("Enter the number of students: ");
            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                string studentName = Console.ReadLine();
                Students student = new Students(i + 1, studentName);
                academy.AddStudent(student);

             
                Console.Write($"Enter the number of courses for student {studentName}: ");
                int studentCourseCount = int.Parse(Console.ReadLine());

                for (int j = 0; j < studentCourseCount; j++)
                {
                    Console.Write($"Enter the name of course {j + 1} for student {studentName}: ");
                    string courseName = Console.ReadLine();
                    Course course = academy.Courses.Find(c => c.CourseName == courseName);

                    if (course != null)
                    {
                        student.EnrollCourse(course);
                    }
                    else
                    {
                        Console.WriteLine($"Course {courseName} not found.");
                    }
                }
            }

            academy.PrintAcademyData();
        }
    }
}
