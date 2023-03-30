using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percent
{
    internal class Program
    {
        public static double Calculate(string userInput)
        {
            var arr = userInput.Split();
            var money = double.Parse(arr[0].Replace('.', ','));
            var percent = double.Parse(arr[1].Replace('.', ','));
            var months = Int32.Parse(arr[2]);

            var incresedManey = money * Math.Pow(1 + (percent / 100) / 12, months);

            return incresedManey;
        }
        static void Main(string[] args)
        {
            
            var userInput = Console.ReadLine();

            Console.WriteLine(Calculate(userInput));
            Console.ReadKey();
        }
    }
}
