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
            //Задача 4
            //Пользователь вводит высоту и ширину кирпича. Программа проверяет пролезет ли кирпич в прямоугольное отверстие с высотой 50 и шириной 120.

            Console.WriteLine("Введите высоту кирпича a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину кирпича b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a * b;
            double d = 50 * 120;

            if ((c > d) && (c == d))
            {
                Console.WriteLine("Кирпич не пролезет");
            }
            else
            {
                Console.WriteLine("Кирпич пролезет");
            }

            Console.ReadKey();




        }
    }
}
