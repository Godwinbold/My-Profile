using PayRollMax.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollMax.Logic.Interface
{
    public interface IPayRollLogic
    {
        string AddSalaray(Salary salary);
        Salary GetSalary(string Id);

        List<Salary> GetSalaries();

        bool DeleteSalary(string Id);

        decimal CalculateGrossPay(decimal regRate, decimal overtimeRate, int regHour, int overtimeHour);

        decimal CalculateNet(decimal gross, decimal totalDeductions);

        decimal CalculateDeduction(decimal percentage, decimal gross);
    }
}
