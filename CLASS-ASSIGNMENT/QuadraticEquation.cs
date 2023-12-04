using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_ASSIGNMENT
{
    public class QuadraticEquation
    {
        public void equation (double a,double b, double c)
        {
            double x1 = ((-1 * b) + ((b * b) - (4 * a * c))) / (2 * a);
            double x2 = ((-1 * b) - ((b * b) - (4 * a * c))) / (2 * a);

            Console.WriteLine($"The Squeareroot of the equation: {x1}, {x2}");

        }
    }
}
