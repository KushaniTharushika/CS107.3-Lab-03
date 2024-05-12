using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Course course = new Course("Computer Science", "kamal perera", 85);
                course.PrintCourseInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
