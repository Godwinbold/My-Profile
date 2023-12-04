using PayRollMax.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollMax.Logic.Interface
{
    public interface IEmployeeLogic
    {

        string AddEmployee(Employee employee);
        Employee GetEmployee(string Id);

        List<Employee> GetEmployees();

        bool DeleteEmployee(string Id);
    }  
}
