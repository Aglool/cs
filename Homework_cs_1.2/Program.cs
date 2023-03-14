using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_cs_1._2
{
    class Program
    {
        //ввести три числа и вывести на экран их сумму и произведение
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double p = a * b * c;
            double s = a + b + c;

            Console.WriteLine("a * b * c = " + p);
            Console.WriteLine("a + b + c = " + s);
        }
    }
}
