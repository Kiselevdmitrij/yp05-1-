using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 2
            // Пользователь вводит три числа. Программа выводит на экран большее из трех чисел.

            Console.WriteLine("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число с: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > b && a > c) 
            {
                Console.WriteLine($"Большее число = {a}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"Большее число = {b}");
            }
            else if (c > b && c > b)
            {
                Console.WriteLine($"Большее число = {c}");
            }
            
            Console.ReadKey();
        }
    }
}
