using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.No2
{
    internal class Course
    {
        private string courseName;
        private string email;
        private List<Students> enrolledStudents;

        public Course(string name, string email)
        {
            this.courseName = name;
            this.email = email;
            this.enrolledStudents = new List<Students>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                this.courseName = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
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

        public void AddStudent(Students student)
        {
            enrolledStudents.Add(student);
        }
    }
}
