using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  
            * треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона.
            */
            Console.Write("Введите длину 1-ой стороны 1-ого треугольника. А1=");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину 2-ой стороны 1-ого треугольника. B1=");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину 3-ей стороны 1-ого треугольника. С1=");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите длину 1-ой стороны 2-ого треугольника. А2=");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину 2-ой стороны 2-ого треугольника. B2=");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину 3-ей стороны 2-ого треугольника. С2=");
            double c2 = Convert.ToDouble(Console.ReadLine());

            if (GeronArea(a1, b1, c1) > GeronArea(a2, b2, c2))
            {
                Console.WriteLine("\nПлошадь 1-ого треугольника больше, чем 2-ого.");
            }
            else if (GeronArea(a1, b1, c1) < GeronArea(a2, b2, c2))
            {
                Console.WriteLine("\nПлошадь 2-ого треугольника больше, чем 1-ого.");
            }
            else
            {
                Console.WriteLine("\nПлошади треугольников равны.");
            }

            Console.ReadKey();
        }
        static double GeronArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
