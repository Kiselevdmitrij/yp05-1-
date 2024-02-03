using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число с: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = Math.Max(Math.Max(a,b),c);
            Console.WriteLine($"Большее число: {d} ");
            Console.ReadKey();
        }
    }
}
