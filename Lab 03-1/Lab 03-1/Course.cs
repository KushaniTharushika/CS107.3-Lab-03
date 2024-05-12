using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_1
{
    internal class Course
    {
        private string courseName;
        private string InstructorName;
        private double grade;

        public string CourseName { get { return courseName; } }
        public double Grade
        {
            get { return grade; }
            set
            {
                grade = value;
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }

        }

        public Course(string courseName, string InstructorName, double grade)
        {
            this.courseName = courseName;
            SetInstructorName(InstructorName);
            Grade = grade;
        }

        private void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrWhiteSpace(instructorName))
                throw new ArgumentNullException("Instructor name cannot be empty or null");
            this.InstructorName = instructorName;
        }

        private string CalculateGrade()
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }

        public void PrintCourseInfo()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Instructor Name: " + InstructorName);
            Console.WriteLine("Letter Grade: " + CalculateGrade());
        }

    }
}
