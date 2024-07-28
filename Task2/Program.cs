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
            Console.WriteLine("Введите сторону куба");
            double h = Convert.ToDouble(Console.ReadLine());

            double s = 0;
            double v = 0;

            GetCubeParams(h, out s, out v);
            Console.WriteLine("Площадь поверхности куба ({0:.00}), объем куба ({1:.00})", s, v);
            Console.ReadKey();

        }

        static void GetCubeParams(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
    }
}
