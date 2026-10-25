using System;
using System.ComponentModel.DataAnnotations;
namespace ForeachProject
{
    class Progtam
    {
        static void Main()
        {
            short[] q = { 1, 2, 3, 4, 5, 6 };
            foreach (short w in q)
                Console.WriteLine(w);


            //ЗАДАЧА 1
            int[] num = new int[5];
            Console.WriteLine("Введите 5 чисел: ");

            for (int i = 0; i < num.Length; i++)
                num[i] = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            foreach (int i in num)
                sum += i;
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine();

            //ЗАДАЧА 2
            int[] numb = new int[5];
            Console.WriteLine("Введите 5 чисел: ");

            for (int i = 0; i < numb.Length; i++)
                numb[i] = Convert.ToInt32(Console.ReadLine());

            int max = numb[0];
            foreach (int i in numb)
                if (i > max) max = i;

            Console.WriteLine($"Наибольшее: {max}");
            Console.WriteLine();

            //ЗАДАЧА 3
            int[] number = new int[5];
            Console.WriteLine("Введите 5 чисел: ");

            for (int i = 0; i < number.Length; i++)
                number[i] = Convert.ToInt32(Console.ReadLine());

            int chetn = 0;
            foreach (int n in number)
                if (n % 2 == 0) chetn++;

            Console.WriteLine($"Кол-во четных чисел: {chetn}");
            Console.WriteLine();

            //ЗАДАЧА 4
            string[] words = new string[5];
            Console.WriteLine("Введите 5 слов: ");

            for (int i = 0; i < words.Length; i++)
                words[i] = Console.ReadLine();

            foreach (string n in words)
                    Console.WriteLine($"{n} - {n.Length} символов");

        }
    }
}