using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = (a + 4 * b) * (a - 3 * b) + a * a;
            Console.WriteLine($"c = {c}");
            Console.ReadKey();
        }
    }
}
