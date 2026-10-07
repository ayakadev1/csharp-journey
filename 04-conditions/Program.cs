using System;
namespace Conditions 
{
    class Program 
    {
        static void Main() 
        {
            // ЗАДАЧА 1
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num % 2) != 0)
                Console.WriteLine($"Число {num} нечетное!");
            else
                Console.WriteLine($"Число {num} четное!");
            Console.WriteLine();

            // ЗАДАЧА 2
            Console.Write("Введите балл: ");
            int point = Convert.ToInt32(Console.ReadLine());
            if ( point >=90 && point <= 100)
                Console.WriteLine("Оценка \"Отлично\"");
            else if (point >=70 && point <=89)
                Console.WriteLine("Оценка \"Хорошо\"");
            else if (point >=50 && point <= 69)
                Console.WriteLine("Оценка \"Удовлетворительно\"");
            else if (point >= 0 && point<=49)
                Console.WriteLine("Оценка \"Неудовлетворительно\"");
            else
                Console.WriteLine("Некорректный балл");
            Console.WriteLine();

            // ЗАДАЧА 3
            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите операцию: ");
            string operation = Console.ReadLine();
            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            switch (operation)
            {
                case"+":
                    Console.WriteLine($"Результат: {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {number1 * number2}");
                    break;
                case "/":
                    Console.WriteLine($"Результат: {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            Console.WriteLine();

            // ЗАДАЧА 4
            Console.Write("Введите месяц (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Неверный номер месяца");
                    break;
            }
        }
    }
}
