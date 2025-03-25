using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть сторону трикутника (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        double r = a / (2 * Math.Sqrt(3));

        Console.WriteLine($"Радіус вписаного кола: {r:F2}");
    }
}
