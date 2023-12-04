
using CLASS_ASSIGNMENT;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Enter a value: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b value: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter c value: ");
        c = double.Parse(Console.ReadLine());

        QuadraticEquation quadraticEquation = new QuadraticEquation();
        quadraticEquation.equation(a, b, c);
    }

}
