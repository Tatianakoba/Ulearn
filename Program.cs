
using System;
//Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?

namespace Ulearn
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите два числа: ");

            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);

            }

            Array.Reverse(array);
            foreach (int s in array)
            {
                Console.Write(Convert.ToString(s));
                Console.Write(" ");
            }


            Console.ReadKey();
        }
    }
}

