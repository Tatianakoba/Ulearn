
//Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=50 (5*10)      
        b = a / b; //b=5 (50/10)      
        a = a / b; //a=10 (50/5)    
        Console.WriteLine("After swap a= " + a + " b= " + b);



        int c = 5, d = 10;
        Console.WriteLine("Before swap c= " + c + " d= " + d);
        c = c + d; //c=15 (5+10)      
        d = c - d; //d=5 (15-10)      
        c = c - d; //c=10 (15-5)   
        Console.Write("After swap c= " + c + " d= " + d);

        Console.ReadKey();
    }
}
