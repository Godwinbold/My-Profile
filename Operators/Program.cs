//ARITHMETIC OPERATORS

// Addition(+), Subtraction(-), Division(/), Multiplication(*), Modulus(%)

//Addition

//int x = 5;
//int y = 6;
//int result = x + y;
//Console.WriteLine(result);

//int x = 10;
//int y = x++;

//Console.WriteLine(x);
//Console.WriteLine(y);

//what is y
//int x = 7;
//int y = x *= 2;
//Console.WriteLine(y);

//double x = 10;
//int y = 3;
//double result = x / y;
//Console.WriteLine(result);

//int x = 7;
//x *= 2;
//Console.WriteLine(x);


//int x = 14;
//x -= 2;
//Console.WriteLine(x);


//int y = 15;
//int z = 16;
//bool result = y! < z;
//Console.WriteLine(result);

//string y = "Ferdinand";
//string x = "Ferdinand";
//string z = "JOHN";
//bool result = string.Equals(z, y);
//Console.WriteLine(result);

//string[] names = { "john", "godwin", "Francis" };

//foreach (string name in names)
//{
//    Console.WriteLine($"Your name is {name} ");
//}


//String Comparison
//string.CompareTo();
//string x = "7";
//string y = "8";
//int results = x.CompareTo(y);
//Console.WriteLine(results);

//string x = "Godwin";
//string result = x.Substring(2, 2);
//Console.WriteLine(result);

//string x = "Godwin";
//string result = x.ToCharArray(2, 2);
//Console.WriteLine(result);
//Array.Reverse(result);

//Write a programme that ask the user for total amoumt of time in minutes only.
//print to the console the same amount of time in hours and minutes.


//using System.ComponentModel.Design;
//using System.Globalization;

//int Time = 0;

//Console.WriteLine("please enter time: ");
//Time = int.Parse(Console.ReadLine());

//if (Time < 60)
//{
//    Console.WriteLine($"The time is = 0 hours  {Time} minutes");
//}
//else
//{
//    int hour = Time / 60;
//    int minute = Time % 60;

//    Console.WriteLine($"{Time} minute is {hour} hour(s) {minute} minutes");

//}


//write a programme that asks a user to enter a number. Check if the number is even or odd and print it out on the console
// expected. 3 is an odd number.

//Console.Write("please enter number: ");
//int num = int.Parse(Console.ReadLine());

//    if (num % 2 == 0)
//    {
//        Console.WriteLine($"{num} is an even number");
//    }
//    else
//    {
//        Console.WriteLine($"{num} is an odd number");
//    }


//int[] numbers = { 5, 6, 7, 8, 9, 10 };
//var nums = new int[3];
//int x = 0;

//for (int i = 0; i < 6; i++)

//{
//    if (numbers[i] % 2 == 0)
//    {
//        nums[x] = numbers[i];
//        x++;
//    }
//}
//foreach (var ans in nums)
//{
//    Console.WriteLine(ans);
//}

//string[] persons = { "Peter", "samson", "confidence" };



//Console.WriteLine(persons[1]);

//string[] boys = { "Mike", "john", "francis", "louis" };

//int [] age = { 3,5,6,7,8,9 };

//var person = age[2];

//Console.WriteLine(age[2]);


Console.WriteLine("Please, enter a number: ");
int time = int.Parse(Console.ReadLine());

if (time % 2 < 60)
{
    Console.WriteLine($"The time is hour {time} is number");
}


