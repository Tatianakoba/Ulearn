using System;
//Expr3.Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.

namespace Watch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите время(ровно): ");

            string parts = Console.ReadLine();
            int time = int.Parse(parts);
            if (time <= 6 ) 
            {
                time *= 30;
                Console.WriteLine($"Угол между часовой и минутной стрелками равен {time}", time);

            }
            else if ((6 < time)&&(time<12))  
            {
                time = 360 - (time * 30);
                Console.WriteLine($"Угол между часовой и минутной стрелками равен {time}", time);
            }
            else if ((time >=12)&&(time<=18))
            {
                time = (time - 12) * 30;
                Console.WriteLine($"Угол между часовой и минутной стрелками равен {time}", time);
            }
            else
            {
                time = 360 - ((time - 12) * 30);
                Console.WriteLine($"Угол между часовой и минутной стрелками равен {time}", time);
            }
            Console.ReadKey();
        }
    }
}
