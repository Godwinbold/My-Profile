using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollMax.Model
{
    internal class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }

    }
}
