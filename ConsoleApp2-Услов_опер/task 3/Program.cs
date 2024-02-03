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
            // Задача 3
            // Пользователь вводит три числа. Найдите те два из них, сумма которых наибольшая.
            Console.WriteLine("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double sum1 = a + b;
            double sum2 = a + c;
            double sum3 = b + c;

            if ((sum1 > sum2) && (sum1 > sum3))
            {
                Console.WriteLine($"Наибольшая сумма (a + b): {sum1}");
            }
            else if ((sum2 > sum1) && (sum2 > sum3))
            {
                Console.WriteLine($"Наибольшая сумма a + c: {sum2}");
            }    
            else if ((sum3 > sum1) && (sum3 > sum2))
            {
                Console.WriteLine($"Наибольшая сумма b + c: {sum3}");
            }

            Console.ReadKey();

        }
    }
}
