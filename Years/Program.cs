//Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Years
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите два года а и b ");
            string[] parts = Console.ReadLine().Split(' ', ',', '.');

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int k = 0;
            for (int i = a; i <= b; i++)
            {

                if ((i % 4 == 0)&&(i % 100 !=0 ))
                
                    k++;               
                
                if ((i % 100 == 0) && (i % 400 == 0))

                    k++;

            }
            Console.WriteLine($"На отрезке от {a} до {b} количество високосных лет {k}", a, b, k);
            Console.ReadKey();
        }
    }
}
