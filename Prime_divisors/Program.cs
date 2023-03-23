//Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_divisors
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введите N,X,Y ");

            string [] parts = Console.ReadLine().Split(' ',',','.');
                       
            int N = int.Parse(parts[0]);
            int X = int.Parse(parts[1]);
            int Y = int.Parse(parts[2]);
            int k=0;

            //double k = ((N-1)/X + (N-1)/Y-(N-1)/(X*Y)); решение в одну строку без цикла
            for (int i = 1;  i < N; i++) 
            {

                if (i % X == 0 | (i % Y == 0))
                    k++;
                
            }
            Console.WriteLine($"Количество чисел меньших N,которые имеют простые делители X и Y равно {k}", k);


            Console.ReadKey();
        }
    }
}
