using System;
namespace Variables
{
    class Program
    {
        static void Main()
        {
            /* 
             * эти типы данных ТОЛЬКО для целых чисел
             * дробные нельзя 
             */

            byte z = 11; //это самый маленький тип данных 8 битный тип
            short x = 22; //побольше, 16 битный тип
            int c = 33; //это уже чаще используемый тип тк чисел больше, 32 битный тип
            uint ui = 44; //то же самое что и int, но можно ТОЛЬКО положительные числа
            long w = 55; //самый большой тип данных

            //дальше НЕ целые числа
            float e = 66.66f; //он содержит в себе не целые числа, можно как отрицательные так и положительные (суффикс f на конце обязательно, что бы программа не путалась)
            double r = 77.77d; //дабл уже больше чем флоат, можно хранить более большие дробные числа (суффикс d на конце не обязательно)
            decimal d = 88.88m; // декимал работает более точно, часто используется в работе с деньгами (суффикс m на конце обязательно, что бы программа не путалась)

            //далее типы данных не для чисел, а для символов
            string f = "привет дружище"; //содержит слова или предложения, но может быть пуст
            char s = 'v'; //содержит только один символ, сам символ обозначается одинарными кавычками
            bool b = true; //бул это банально истина или ложь
            bool a = false;

            //делаю так, что бы программа подставляла данные введенные пользователем в переменные

            int i, h;
            Console.WriteLine("Введите первое целое число");
            i = Convert.ToInt32(Console.ReadLine());                                  //конвертируем число из стринга в инт тк реад лайн подразумевает ввод стринга
            Console.WriteLine("Введите второе целое число");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Первое число:\t{i}\nВторое число:\t{h}");
            Console.WriteLine();

            // ===== ЗАДАЧИ =====

            //1 ЗАДАЧА
            int age;
            string name, animal;
            Console.WriteLine("Как тебя зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько тебе лет?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какое у тебя любимое животное?");
            animal = Console.ReadLine();
            Console.WriteLine($"Привет, {name}. Тебе {age}.\nТебе нравится {animal}? Мне тоже!");
            Console.WriteLine();

            //2 ЗАДАЧА
            double num1, num2;
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Сложение:\t{num1 + num2}");
            Console.WriteLine($"Вычитание:\t{num1 - num2}");
            Console.WriteLine($"Умножение:\t{num1 * num2}");
            Console.WriteLine($"Деление:\t{num1 / num2}");
        }
    }
}