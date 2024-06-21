using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.No2
{
    internal class Students
    {
        private int studentId;
        private string name;
        private List<Course> enrolledCourses;

        public Students(int studentId, string name)
        {
            this.studentId = studentId;
            this.name = name;
            this.enrolledCourses = new List<Course>();
        }
        public int StudentId
        {
            get
            {
                return this.studentId;
            }
            set
            {
                this.studentId = value;
            }
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
        public List<Course> EnrolledCourses
        {
            get
            {
                return this.enrolledCourses;
            }
            set
            {
                this.enrolledCourses = value;
            }
        }


        public void EnrollCourse(Course course)
        {
            EnrolledCourses.Add(course);
            course.AddStudent(this);
        }
    }
}
