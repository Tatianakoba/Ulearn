using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame
{
    internal class Program
    {
        private static void WriteTextWithBorder(string text)
        {
            string frame = "+";
            for (int i = 0; i < text.Length + 2; i++)
            {
                frame += "-";
            }
            frame += "+";
            Console.WriteLine(frame);
            Console.WriteLine("| " + text + " |");
            Console.WriteLine(frame);
        }

        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
