using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_METHODING
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int ID;


        public Person()
        {
        }

        public Person(string firstname, string lastname, int id)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            Console.WriteLine("This console was created for the person below\n");
        }

    }
}
