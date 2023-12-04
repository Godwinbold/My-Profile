using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter number: \n");
            int num = int.Parse(Console.ReadLine());

               if (num % 2 == 0)
              
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
        }
    }
}
