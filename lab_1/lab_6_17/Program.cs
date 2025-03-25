using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть значення x:");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Некоректне значення x.");
            return;
        }

        Console.WriteLine("Введіть значення y:");
        if (!double.TryParse(Console.ReadLine(), out double y))
        {
            Console.WriteLine("Некоректне значення y.");
            return;
        }

        double baseValue = (1 / (x * y)) - (1 / (x * x + 1));
        double result = baseValue * (x + y);

        Console.WriteLine($"Результат обчислення: {result}");
    }
}
