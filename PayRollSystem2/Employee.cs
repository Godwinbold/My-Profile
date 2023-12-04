using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollSystem2
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal HoursRate { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal TaxRate { get; set; }
    }



    //public Employee(int employeeId, string employeeName,
    //            DateTime startDate, DateTime endDate, 
    //            decimal hoursRate, decimal hoursWorked,
    //            decimal taxRate) 
    //{
    //            EmployeeId = employeeId;
    //            EmployeeName = employeeName;
    //            StartDate = startDate;
    //            EndDate = endDate;
    //            HoursRate = hoursRate;
    //            HoursWorked = hoursWorked;
    //            TaxRate = taxRate;

    //}



    public static Employee CreateEmployee()
        {
            Console.Write("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Hourly Rate: ");
            double hourlyRate = double.Parse(Console.ReadLine());
            Console.Write("Enter Hours Worked: ");
            double hoursWorked = double.Parse(Console.ReadLine());
            Console.Write("Enter Tax Rate (e.g., 0.15 for 15%): ");
            double taxRate = double.Parse(Console.ReadLine());

            return new Employee();

        }





    }
