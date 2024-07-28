using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double area1 = GetArea(x1, y1, z1);

            Console.WriteLine("Введите стороны второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double area2 = GetArea(x2, y2, z2);

            if (area1 == -1 || area2 == -1)
            {
                Console.WriteLine("Не возможно сфоормировать треугольник");
            }
            else
            {
                if (area1 > area2)
                {
                    Console.WriteLine("Площадь первого треугольника ({0:.00}) больше второго ({1:.00})", area1, area2);
                }
                else if (area1 < area2)
                {
                    Console.WriteLine("Площадь первого треугольника ({0:.00}) меньше второго ({1:.00})", area1, area2);
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны ({0:.00}) и ({1:.00})", area1, area2);
                }
            }


            Console.ReadKey();
        }

        static double GetArea(double x, double y, double z)
        {
            if (x + y <= z || x + z <= y || y + z <= x)
            {
                return -1;
            }
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
    }
}
