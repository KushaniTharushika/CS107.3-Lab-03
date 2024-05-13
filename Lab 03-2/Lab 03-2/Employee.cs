using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_2
{
    internal class Employee
    {
        private int employee_Id;
        private string employee_Name;
        private double salary;

        public int Employee_Id { get { return employee_Id; } }
        public string FullName
        {
            get { return employee_Name; }
            set { employee_Name = value; }
        }
        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public Employee(int employee_Id, string employee_Name, double salary)
        {
            this.employee_Id = employee_Id;
            employee_Name = FullName;
            salary = Salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID: " +  employee_Id);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Salary: " +  Salary);
        }


    }
}
