using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST_ARRAY
{
    public class Rectangle
    {
        //public double Lenght { get; set; }
        //public double Heigth { get; set; }


        //public string Area(double length, double heigth)
        //{
        //    return Lenght * Heigth;
        //}


      public  class Person
        {
            public string FirstName;
            public string LastName;
            public int Age;



            public Person(string firstname, string lastName, int age)
            {
                this.FirstName = firstname;
                LastName = lastName;
                Age = age;


                Person person = new Person();

                Console.WriteLine();

            }

        }

         
    }

    
    
}
