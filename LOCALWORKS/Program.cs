// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Enter a number");
string userInputNumber = Console.ReadLine();

try
{
    int Parsedinput = int.Parse(userInputNumber);
    Console.WriteLine($"You entered :  {userInputNumber}");
}
catch (FormatException)
{
    {
        Console.WriteLine("You entered an invalid Number");
    }
}    
