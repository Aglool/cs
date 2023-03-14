using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_cs_1._3
{
    class Program
    {
        //простой конвертер валют (доллары в рубли)
        static void Main(string[] args)
        {
            double a = 60.78;

            double b = Convert.ToDouble(Console.ReadLine());

            double c = a * b;
            Console.WriteLine(c + " рублей в " + b + " долларах");
        }
    }
}
