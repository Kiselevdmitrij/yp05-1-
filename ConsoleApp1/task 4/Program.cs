using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.6;
            double s = Math.Exp(x - 2) + Math.Abs(Math.Sin(x)) - Math.Pow(x,4) * Math.Cos(1/x);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
