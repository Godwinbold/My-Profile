using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollSystem2
{
public class EmployeePayroll : Employee
    {
        
                public void AddEmployee(Employee employee)
        {
            
        }

                public void DisplayPayroll() 
        { 
       
        }

        public double CalculatePayroll()
        {
            // Calculate total payroll
            double totalPayroll = 0;
            foreach (var employee in employees)
            {
                totalPayroll += employee.CalculatePayroll();
            }
            return totalPayroll;
        }
    }

}
