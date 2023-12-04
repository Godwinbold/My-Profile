using PayRollSystem2;
using System;

namespace ConsolApplication
{
 class program
  {
 public void Main(string[] args)
 
        
        {
            
                EmployeePayroll payrollSystem = new EmployeePayroll();

                while (true)
                {
                    Console.WriteLine("Options:");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. Calculate Payroll");
                    Console.WriteLine("3. Display Payroll");
                    Console.WriteLine("4. Exit");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Employee employee = Employee.CreateEmployee();
                            payrollSystem.AddEmployee(employee);
                            break;
                        case "2":
                            double totalPayroll = EmployeePayroll.CalculatePayroll();
                            Console.WriteLine($"Total Payroll: ${totalPayroll}");
                            break;
                        case "3":
                            payrollSystem.DisplayPayroll();
                            break;
                        case "4":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            
        }



             static void DisplayPayroll()
            {
                // Display payroll in a tabular format
                Console.WriteLine("Payroll Report");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Employee ID\tName\tSalary\tDeductions\tNet Salary");
                Console.WriteLine("----------------------------------------");

                foreach (var employee in employee)
                {
                    double salary = employee.CalculateSalary();
                    double deductions = employee.CalculateDeductions();
                    double netSalary = salary - deductions;
                    Console.WriteLine($"{employee.EmployeeId}\t\t{employee.FirstName} {employee.LastName}\t${salary}\t${deductions}\t${netSalary}");
                }


                    }
  }
}



