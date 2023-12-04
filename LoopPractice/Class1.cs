using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    public class Person
    {
        public string Title;

        public string FirstName;
        public string LastName;
        public int ID;
        public int Age;
        public string Gender;

        public Person(string title,string firstname, string lastname, int argid, int age, string gender) 
        {
            Title=title;
            FirstName = firstname;
            LastName = lastname;
            ID = argid;
            Age = age;
            Gender = gender;

            Console.WriteLine("This document was created for " + firstname);
        }
        
    }

    
}
