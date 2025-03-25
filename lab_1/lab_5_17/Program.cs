using System;

class Program
{
    static int Cube(int num)
    {
        return num * num * num;
    }

    static void Main()
    {
        Console.WriteLine("Введіть ціле число для піднесення в куб:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"{number} в кубі дорівнює {Cube(number)}");
        }
        else
        {
            Console.WriteLine("Некоректне введення.");
        }
    }
}

