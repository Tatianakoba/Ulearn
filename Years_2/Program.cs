////Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Years_2
{
    internal class Program
    {
        public static int CountLeapYears(int a, int b)
        {
            int count = (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0)) ? 1 : 0;

            if (a < b)
                count += CountLeapYears(a + 1, b);

            return count;
        }
        static void Main(string[] args)
        {
         Case1:


            Console.Write("Введите два года а и b ");
            string[] parts = Console.ReadLine().Split(' ', ',', '.');

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            
            if (a > b)
            {
                Console.WriteLine("Некорректный промежуток, попробуйте еще раз ");
                goto Case1;
            }
            Console.WriteLine("Количество високосных годов в промежутке " + CountLeapYears(a, b));


            Console.ReadKey();
        }
    }
}
