using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_cs_1._6
{
    class Program
    {
        //подсчёт кол-ва четных и нечетных чисел в том диапазоне, который укажет пользователь
        static void Main(string[] args)
        {
            int count = 0;
            int count2 = 0;
            int num = 0;
            Console.Write("Введите диапазон: ");
            int limit = int.Parse(Console.ReadLine());
            while (num < limit)
            {
                if (num % 2 == 0)
                {
                    count += 1;
                }
                else
                {
                    count2 += 1;
                }
                num++;
            }
            Console.WriteLine("Количество четных чисел: " + count);
            Console.WriteLine("Количество нечетных чисел: " + count2);
            Console.ReadLine();
        }
    }
}
