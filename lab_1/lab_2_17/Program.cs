using System;

class lab_2_17
{
    static void Main()
    {
        Console.Write("Введіть сторону a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть сторону c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (IsTriangle(a, b, c))
        {
            Console.WriteLine("Трикутник існує.");
        }
        else
        {
            Console.WriteLine("Трикутник НЕ існує.");
        }
    }

    static bool IsTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}