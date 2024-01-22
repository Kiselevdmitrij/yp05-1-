using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -2.34;
            double c = (Math.Abs(x - 5) - Math.Sin(x)) / 3 + Math.Sqrt(x * x + 2014) * Math.Cos(2 * x) - 3;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
