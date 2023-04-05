//Expr10. Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_progression
{
    internal class Program
    {
        public static int Arithmetic_Progression( int a, int b, int d)
        {

            decimal  n = ((b - a)/ d)+1; 
            
            decimal aN = a + d *(n - 1);
            

            decimal sum = ((a + aN)/2) * n;
            
           
            return (int)Math.Ceiling(sum);
        }
        static void Main(string[] args)
        {
            int sum1 = Arithmetic_Progression(0, 999, 3);
            int sum2 = Arithmetic_Progression(0, 999, 5);
            int sum3 = Arithmetic_Progression(0, 999, 15);
            int sumNumbers = sum1+sum2-sum3;
            Console.WriteLine(sumNumbers);
            Console.ReadKey();

        }
    }
}
