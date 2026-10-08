using System;
namespace Loops
{
    class Program
    {
        static void Main()
        {
            // ЗАДАЧА 1
            Console.Write("Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double y = 0d;
            for (double x = 1d; x <= num; x++)
            {
                y = y + x;
                Console.Write(x);
                if (x < num)
                    Console.Write("+");
                else
                {
                    Console.Write("=");
                }
            }
            Console.WriteLine(y);
            Console.WriteLine();

            // ЗАДАЧА 2
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double q = number;
            for (int i = 1; i <= 10; i++)
            {
                q = number*i;
                Console.WriteLine($"{number} x {i} = {q}");
            }
            Console.WriteLine();

            //ЗАДАЧА 3
            Console.Write("Введите число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double b = 0d;
            Console.Write($"!{num1} = ");
            double t = 1;
            while (num1 > b)
            {
                b++;
                t = t * b;
                if (num1 > b)
                    Console.Write($"{b} x ");
                else
                    Console.WriteLine($"{b} = {t}");
            }
            if (num1 == 0)
                Console.WriteLine("1");
            Console.WriteLine();

            // ЗАДАЧА 4
            Console.WriteLine("Все четные числа от 1 до 20:");
            for (byte l = 1; l <= 20; l++)
            {
                if (l % 2 == 0)
                    Console.WriteLine($"{l}");
            }
        }
    }
}