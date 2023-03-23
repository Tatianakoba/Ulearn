//Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты точки А (x1,y1): ");
            string[] parts = Console.ReadLine().Split(' ', ',', '.');

            int x1 = int.Parse(parts[0]);
            int y1 = int.Parse(parts[1]);

            Console.Write("Введите координаты прямой (x2,y2), (x3,y3): ");
            string[] parts2 = Console.ReadLine().Split(' ', ',', '.');

            int x2 = int.Parse(parts2[0]);
            int y2 = int.Parse(parts2[1]);
            int x3 = int.Parse(parts2[2]);
            int y3 = int.Parse(parts2[3]);

            double st1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double st2 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double st3 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double p = (st1 + st2 + st3) / 2;
            double h = 2 * Math.Sqrt(p * (p - st1) * (p - st2) * (p - st3)) / st2;
            Console.WriteLine("Расстояние равно = " + h);
            Console.ReadKey();
        }
    }
}
