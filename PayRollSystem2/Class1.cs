//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PayRollSystem2
//{
//    internal class Class1
//    {
//        using System;
//using System.Collections.Generic;

//class Employee
//    {
//        // ... (Employee class properties and methods)

//        public static Employee CreateEmployee()
//        {
//            Console.Write("Enter Employee ID: ");
//            int employeeId = int.Parse(Console.ReadLine());
//            Console.Write("Enter First Name: ");
//            string firstName = Console.ReadLine();
//            Console.Write("Enter Last Name: ");
//            string lastName = Console.ReadLine();
//            Console.Write("Enter Hourly Rate: ");
//            double hourlyRate = double.Parse(Console.ReadLine());
//            Console.Write("Enter Hours Worked: ");
//            double hoursWorked = double.Parse(Console.ReadLine());
//            Console.Write("Enter Tax Rate (e.g., 0.15 for 15%): ");
//            double taxRate = double.Parse(Console.ReadLine());

//            return new Employee(employeeId, firstName, lastName, hourlyRate, hoursWorked, taxRate);
//        }
//    }

//    class PayrollSystem
//    {
//        private List<Employee> employees = new List<Employee>();

//        public void AddEmployee(Employee employee)
//        {
//            employees.Add(employee);
//        }

//        public double CalculatePayroll()
//        {
//            // Calculate total payroll
//            double totalPayroll = 0;
//            foreach (var employee in employees)
//            {
//                totalPayroll += employee.CalculateSalary();
//            }
//            return totalPayroll;
//        }

//        public void DisplayPayroll()
//        {
//            // Display payroll in a tabular format
//            Console.WriteLine("Payroll Report");
//            Console.WriteLine("----------------------------------------");
//            Console.WriteLine("Employee ID\tName\tSalary\tDeductions\tNet Salary");
//            Console.WriteLine("----------------------------------------");

//            foreach (var employee in employees)
//            {
//                double salary = employee.CalculateSalary();
//                double deductions = employee.CalculateDeductions();
//                double netSalary = salary - deductions;
//                Console.WriteLine($"{employee.EmployeeId}\t\t{employee.FirstName} {employee.LastName}\t${salary}\t${deductions}\t${netSalary}");
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            PayrollSystem payrollSystem = new PayrollSystem();

//            while (true)
//            {
//                Console.WriteLine("Options:");
//                Console.WriteLine("1. Add Employee");
//                Console.WriteLine("2. Calculate Payroll");
//                Console.WriteLine("3. Display Payroll");
//                Console.WriteLine("4. Exit");
//                string option = Console.ReadLine();

//                switch (option)
//                {
//                    case "1":
//                        Employee employee = Employee.CreateEmployee();
//                        payrollSystem.AddEmployee(employee);
//                        break;
//                    case "2":
//                        double totalPayroll = payrollSystem.CalculatePayroll();
//                        Console.WriteLine($"Total Payroll: ${totalPayroll}");
//                        break;
//                    case "3":
//                        payrollSystem.DisplayPayroll();
//                        break;
//                    case "4":
//                        Environment.Exit(0);
//                        break;
//                    default:
//                        Console.WriteLine("Invalid option. Please try again.");
//                        break;
//                }
//            }
//        }
//    }

//}
//}
