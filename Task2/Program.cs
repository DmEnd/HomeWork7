using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

            Console.Write("Введите длину стороны куба. А=");
            double a = Convert.ToDouble(Console.ReadLine());

            double v, s;

            CubeVolumeSurfArea(a, out v, out s);
            Console.WriteLine("Объем куба равен V={0}. Плошади поверхности куба равна S={1}.",v, s);

            Console.ReadKey();
        }

        static void CubeVolumeSurfArea(double a, out double v, out double s)
        {
            v = Math.Pow(a, 3);
            s = Math.Pow(a, 2) * 6;
        }
    }
}
