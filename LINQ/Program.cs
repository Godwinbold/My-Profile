
using System.Linq;
using System.Collections.Generic;
namespace linq;



public class link
{
    public void Main(string[] args)
    {
        var number = new int[] { 1, 2, 3, 4, 5 };
        var filtered = from n in number
                       where n == 4 || n == 5
                       select n;

        foreach(var n in filtered)
        {
            Console.WriteLine(n);
        }
    }
}