using LoopPractice;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Godwin
{
    class program
    {
        static void Main(string[] args)
        {
            
             
            Person person = new Person("Mr ","Godwin","Ozioko",1,34,"Male");

            Console.WriteLine("Happy Birthday to you " + person.Title  + person.FirstName+"," + " God bless you in your new " + person.Age
                );
            Console.WriteLine();
            Console.ReadLine();

        }
       
    }

    
}



