using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

class program
{

    //1,"John", 35, 4.5, 'A';
    public static void Main(string[] args)
    {
        List<string> food = new List<string>();

        food.Add("Paizza");
        food.Add("Rice");
        food.Add("pie");

        foreach (string item in food)
        {
            Console.WriteLine(item);
        }

    }

}





























class person
{
    public int id;
    public string name;
    public int age;
    public double GPA;
    public char Grade;
}
