using System;
using System.ComponentModel.Design;
using THANDWAR;

namespace UnderstandingScope;

    public class program
{

    public class person
    {
        public string Name;

        public void introduce(string to)
        {
            Console.WriteLine($"My name is {0}, i am {1}", to, Name);
        }
    }

    public static void Main(string[] args)
    {
        var person = new person();
        person.Name = "Sam";
        person.introduce("Mike");

    }
}
        


