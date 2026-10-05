using System;
namespace MathProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 дробных числа");
            float num1 = float.Parse(Console.ReadLine()!); // для float нет конвертирования в ToFloat, но есть эта альтернатива
            float num2 = float.Parse(Console.ReadLine()!); // воскл знак говорил компилятору "я знаю, что тут не null, не предупреждай"
            Console.WriteLine();
            float res, sum, difference, product, quotient, remainder;
            sum = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2;
            remainder = num1 % num2;  //остаток от деления (балбесам понятно)
            res = 12f;  //добавляем f, что бы программа понимала, что число принадлежит системе float, а не int32

            res += 3f; //дабавляем к переменной res число 3
            res++;   // это сокращение используется когда нужно добавить +1 к числу
            res--;   // минус соответственно

            Console.WriteLine($"Сложение: {sum}");
            Console.WriteLine($"Вычитание: {difference}");
            Console.WriteLine($"Умножение: {product}");
            Console.WriteLine($"Деление: {quotient}");
            Console.WriteLine($"Остаток: {remainder}");
            Console.WriteLine();
            Console.WriteLine(res);
            Console.WriteLine();

            Console.WriteLine(Math.PI); //число ПИ
            Console.WriteLine(Math.E); //Число Е
            Console.WriteLine(Math.Abs(-11)); //Модуль
            Console.WriteLine(Math.Sqrt(25)); //корень
            Console.WriteLine(Math.Ceiling(42.11)); //округляет к большему числу
            Console.WriteLine(Math.Floor(452.92));  // округляет к меньшему числу
            Console.WriteLine(Math.Round(11.51)); // округляет к билжайшему числу
            Console.WriteLine(Math.Pow(4, 3)); //возвередие 1 числа в степень(2 числ)
            Console.WriteLine(Math.Max(2, 6)); // выбирает наибольшее число из 2
            Console.WriteLine();

            //ЗАДАЧИ
            //1
            Console.WriteLine("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь окружности с радиусом {radius} равна {area}");
            Console.WriteLine();

            //2
            Console.WriteLine("Введите 2 катета прямоугольного треугольника");
            double leg1 = Convert.ToDouble(Console.ReadLine());
            double leg2 = Convert.ToDouble(Console.ReadLine());
            double hypotenuse = Math.Sqrt(Math.Pow(leg1, 2)+Math.Pow(leg2, 2));
            Console.WriteLine($"Гипотенуза с катетами {leg1} и {leg2} равна {hypotenuse}");
            Console.WriteLine();

            //3
            Console.WriteLine("Введите 3 числа");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double x = Math.Max(number1, number2);
            double y = Math.Max(x, number3);
            double z = Math.Min(number1, number2);
            double q = Math.Min(z, number3);
            double average = (number1 + number2 + number3) / 3;
            Console.WriteLine($"Наибольшее число: {y}");
            Console.WriteLine($"Наименьшее число: {q}");
            Console.WriteLine($"Среднее: {average}");
            Console.WriteLine();

            //4
            Console.WriteLine("Введите дробное число");
            double numb = Convert.ToDouble(Console.ReadLine());
            double numb1 = Math.Abs(numb);
            double numb2 = Math.Round(numb);
            double numb3 = Math.Floor(numb);
            double numb4 = Math.Ceiling(numb);
            double numb5 = Math.Pow(numb, 2);
            double numb6 = Math.Sqrt(numb);
            Console.WriteLine($"Модуль: {numb1}\nОкругление: {numb2}\nОкругление вниз: {numb3}\nОкругление вверх: {numb4}\nЧисло в степени 2: {numb5}\nКвадратный корень: {numb6}");
        }
    }
}