using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_cs_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки: ");
            int num = int.Parse(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            Console.ReadLine();
        }
    }
}
