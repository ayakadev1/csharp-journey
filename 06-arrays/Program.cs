using System;
using System.Runtime.InteropServices;
namespace arrays
{
    class Program
    {
        static void Main()
        {
            //ЗАДАЧА 1
            int[] num = new int [5];

            Console.WriteLine("Введите 5 чисел: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            for(byte i = 0; i < num.Length; i++)
                sum = sum + num[i];

            double avg = (double)sum/5;

            Console.WriteLine($"Среднее: {avg}\nСумма: {sum}");
            Console.WriteLine();

            //ЗАДАЧА 2
            int[] number = new int[5];

            Console.WriteLine("Введите 5 чисел: ");
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = number[0];
            int min = number[0];

            for (byte q = 0; q < number.Length; q++)
            {
                if (number[q] > max)
                    max = number[q];
                if (number[q] < min)
                    min = number[q];
            }

            Console.WriteLine($"Min: {min}\nMax: {max}");
            Console.WriteLine();

            //ЗАЧАДА 3
            int[] numb = new int[5];

            Console.WriteLine("Введите 5 чисел: ");
            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Обратный порядок: ");
            for (int i = numb.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numb[i]} ");
            }
            Console.WriteLine();

            //ЗАДАЧА 4
            Console.WriteLine("Введите 5 чисел: ");
            int[] number1 = new int[5];

            for (byte i = 0; i < number1.Length; i++)
                number1[i] = Convert.ToInt32(Console.ReadLine());

            int chet = 0;
            for(byte i = 0;i < number1.Length; i++)
            {
                if (number1[i] % 2 == 0)
                    chet++;
            }
            Console.WriteLine($"Кол-во четных чисел: {chet}");
        }
    }
}