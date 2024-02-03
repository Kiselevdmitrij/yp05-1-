using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Услов_опер
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            // Пользователь вводит два числа. Программа выводит на экран большее из двух чисел.

            Console.WriteLine("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"Большее число = {a}");
            }
            else
            {
                Console.WriteLine($"Большее число = {b}");
            }
            Console.ReadKey();

        }
    }
}
