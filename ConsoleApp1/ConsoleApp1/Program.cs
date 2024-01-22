using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine()); //ввод данных и сохранение ка int
            int z = x + 12;
            int y = x - 6;
            int f = x * 5;
            double i = x / 3;
            Console.WriteLine($"i = {i}");
            Console.ReadKey();
            int a = 10;
            a = a + 8;
            a += 8;
            double ftr = Math.Pow(x, 2); // степень икс в 2
            Console.WriteLine(ftr);
        }
    }
}
