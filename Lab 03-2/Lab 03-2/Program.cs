using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a) Create an instance of the Employee class
            Employee emp = new Employee(21,"Kushani Tharushika",100000);

            // b) Access and display the employee ID
            Console.WriteLine("Employee ID: " + emp.Employee_Id);

            // c) Update the full name
            emp.FullName = "Sheyera Mishma";
            Console.WriteLine("Updated Full Name: " + emp.FullName);

            //d) Attempt to modify the salary directly from external code (outside the class). Observe and comment on the result.
            emp.DisplayEmployeeInfo();

        }
    }
}
