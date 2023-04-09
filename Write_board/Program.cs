using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_board
{
    internal class Program
    {
        private static void WriteBoard(int size)
        {
            size = size;
            
            for (int i = 0; i < size; i++)
            {
                string text1 = "#";
                string text2 = ".";
                if (i % 2 == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(text1);
                        }
                        else
                        {
                            Console.Write(text2);
                        }
                    }

                }
                else
                    for (int j = 0; j < size; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(text2);
                        }
                        else
                        {
                            Console.Write(text1);
                        }
                    }
                Console.WriteLine();

            }           
        }
        static void Main(string[] args)
        {
            WriteBoard(8);
            Console.WriteLine();
            WriteBoard(1);
            Console.WriteLine();
            WriteBoard(2);
            Console.WriteLine();
            WriteBoard(3);
            Console.WriteLine();
            WriteBoard(10);
            
            Console.ReadKey();
        }
    }
}
