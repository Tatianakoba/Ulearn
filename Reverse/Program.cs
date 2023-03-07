using System;
//Expr2.Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.

namespace Replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");

            string parts = Console.ReadLine();
            char[] chars = parts.ToCharArray();
            Console.WriteLine(chars);



            Array.Reverse(chars);
            Console.WriteLine(chars);


            Console.ReadKey();
        }
    }
}
