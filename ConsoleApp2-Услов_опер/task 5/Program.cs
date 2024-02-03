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
            //Задача 5
            //Написать программу, которая по введенному номеру дня недели выводит его название.
            Console.WriteLine("Введите день неджели от 1 до 7: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a){
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Вы вышли из диапазона значений");
                    break;
            }
            Console.ReadKey();

        }
    }
}
