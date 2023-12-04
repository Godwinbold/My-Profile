using PayRollMax.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollMax.Data
{
    public class Contex
    {
        public IList<Employee> Employees { get; set; } = new List<Employee>();
        public IList<Salary> Salaries { get; set; } = new List<Salary>();
    }
}
