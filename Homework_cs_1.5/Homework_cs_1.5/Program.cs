using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_cs_1._5
{
    //простой калькулятор в двух вариантах(switch и if else)
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string sight = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            /*if (sight == "+")
                Console.WriteLine("Сумма чисел равна: " + (num1 + num2));
            else if (sight == "-")
                Console.WriteLine("Разница чисел равна: " + (num1 - num2));
            else if (sight == "*")
                Console.WriteLine("Произведение чисел равно: " + (num1 * num2));
            else if (sight == "/")
                Console.WriteLine("Частное чисел равно: " + (num1 / num2));
            else
            {
                Console.WriteLine("Я ничего не понимаю, у меня IQ 0,75");
            }
            Console.ReadLine();*/

            switch(sight)
            {
                case "+":
                    Console.WriteLine("Сумма чисел равна: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Разница чисел равна: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Произведение чисел равно: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Частное чисел равно: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Я ничего не понимаю, у меня IQ 0,75");
                    break;
            }
            Console.ReadLine();
        }
    }
}
