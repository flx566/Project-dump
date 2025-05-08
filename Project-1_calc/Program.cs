using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое натуральное число:");
        if (!int.TryParse(Console.ReadLine(), out int number1) || number1 <= 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число!");
            return;
        }

        Console.WriteLine("Введите второе натуральное число:");
        if (!int.TryParse(Console.ReadLine(), out int number2) || number2 <= 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число!");
            return;
        }

        Console.WriteLine("Сложение: " + (number1 + number2));
        Console.WriteLine("Вычитание: " + (number1 - number2));
        Console.WriteLine("Умножение: " + (number1 * number2));
        
        if (number2 != 0)
        {
            Console.WriteLine("Деление: " + ((double)number1 / number2));
            Console.WriteLine("Остаток: " + (number1 % number2));
        }
        else
        {
            Console.WriteLine("Деление на 0 невозможно");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}