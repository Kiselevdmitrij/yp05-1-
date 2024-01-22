using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.7;
            double i = Math.Pow((x+1),2) + 3 * (x + 1);
            Console.WriteLine(i);
            int a = 3;
            double s = Math.Pow((a + 1), 2) + 3 * (a + 1);
            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
