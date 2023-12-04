using CLASS_METHODING;
using System;

class program
{
    public static void Main(string[] args)
    {

        var Person = new Person();

        Person.FirstName = "Godwin";
        Person.ID = 1;

        Console.WriteLine();



        //HiThere("Godwin");

        car myCar = new car();
        myCar.make = "Benz";
        myCar.year = 2023;
        myCar.color = "Black";


        car  myNewCar;
        myNewCar = myCar;

        myNewCar.make = "Honda";

        Console.WriteLine("I love my new car {0} {1} {2}",
                                                myNewCar.year, 
                                                myNewCar.color, 
                                                myNewCar.make);

        Console.WriteLine("My favourite car is {0} {1} {2}",
                                                myCar.make,
                                                myCar.color,
                                                myCar.year, 
                                                "Model");

             Console.ReadLine();
    }




    //public static void HiThere(string name)
    //{
    //    Console.WriteLine($"Hello\n" + name);
  
    
    
    
    class car
    {
        public string make { get; set; }
        public string color { get; set; }
        public int year { get; set; }
    }
}
