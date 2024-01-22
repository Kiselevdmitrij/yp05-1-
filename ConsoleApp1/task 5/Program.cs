using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1;
            double b = 0.1;
            int x = 1;
            double tt = 1 / 5.0;
            double r = Math.Pow((Math.Pow(x, 2) + b), tt) - (Math.Pow(b, 2) * Math.Pow(Math.Sin(x + a), 3))/x;
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
