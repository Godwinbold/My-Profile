using System;
using System.Collections.Generic;

class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public Employee(int employeeID, string name, double hourlyRate)
    {
        EmployeeID = employeeID;
        Name = name;
        HourlyRate = hourlyRate;
        HoursWorked = 0;
    }

    public double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }
}

class PayrollSystem
{
    private List<Employee> employees;

    public PayrollSystem()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public double CalculatePayroll()
    {
        double totalPayroll = 0;
        foreach (var employee in employees)
        {
            totalPayroll += employee.CalculateSalary();
        }
        return totalPayroll;
    }
}

class Program
{
    static void Main()
    {
        PayrollSystem payrollSystem = new PayrollSystem();

        while (true)
        {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Add an employee");
            Console.WriteLine("2. Calculate Payroll");
            Console.WriteLine("3. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter employee ID: ");
                    int employeeID = int.Parse(Console.ReadLine());
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter hourly rate: ");
                    double hourlyRate = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(employeeID, name, hourlyRate);
                    payrollSystem.AddEmployee(employee);
                    break;
                case "2":
                    double totalPayroll = payrollSystem.CalculatePayroll();
                    Console.WriteLine($"Total Payroll: ${totalPayroll}");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
