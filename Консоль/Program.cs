using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону равнобедркнного треугольника");
            double side = double.Parse(Console.ReadLine());
            double r = side / Math.Sqrt(3);
            Console.WriteLine(r);

            //====================================Задание1.2======================================//

            Console.Write("Введите a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c=");
            double c = double.Parse(Console.ReadLine());
            if (System.Math.Pow(c, 2) == System.Math.Pow(a, 2) + System.Math.Pow(b, 2))
            {
                Console.Write("Треугольник прямоугольный");
            }
            else
                Console.WriteLine("Треугольник не прямоугольный");

            Console.ReadKey();
        }
    }
}
