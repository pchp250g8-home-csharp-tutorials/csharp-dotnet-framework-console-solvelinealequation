using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveLinealEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input coefficients of lineal equation");
            float.TryParse(Console.ReadLine(), out float a);
            float.TryParse(Console.ReadLine(), out float b);
            Console.WriteLine("Try to solve the equation:{0}*x+{1}=0", a, b);
            if ((a == 0) && (b == 0))
            {
                Console.WriteLine("The answer is any number");
            }
            else if ((a == 0) && (b != 0))
            {
                Console.WriteLine("The equation has no solution");
            }
            else
            {
                Console.WriteLine("The equation has the following solution:{0}", -b / a);
            }
            Console.Read();
        }
    }
}
