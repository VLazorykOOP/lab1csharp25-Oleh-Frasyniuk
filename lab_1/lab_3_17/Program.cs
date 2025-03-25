using System;

class Program
{
    static string CheckPoint(int x, int y)
    {
        if (x > -15 && x < 0 && y > -15 && y < 0)
            return "Так";
        else if ((x == -15 || x == 0) && (y >= -15 && y <= 0) ||
                 (y == -15 || y == 0) && (x >= -15 && x <= 0))
            return "На межі";
        else
            return "Ні";
    }

    static void Main()
    {
        Console.Write("Введіть координати x і y через пробіл: ");
        string[] input = Console.ReadLine().Split();
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);

        Console.WriteLine(CheckPoint(x, y));
    }
}

