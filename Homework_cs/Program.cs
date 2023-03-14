using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_cs
{
    class Program
    {
        //среднее арифмитическое двух чисел
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Среднее арифметическое: ");
            double d = (a1 + b1) / 2;
            Console.WriteLine(d);
        }
    }
}
