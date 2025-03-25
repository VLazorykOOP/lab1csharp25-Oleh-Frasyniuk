using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть ознаку транспортного засобу (a - автомобіль, в - велосипед, м - мотоцикл, с - літак, п - поїзд):");
        char vehicleType = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        int maxSpeed = vehicleType switch
        {
            'a' => 240,  // Автомобіль
            'в' => 50,   // Велосипед
            'м' => 320,  // Мотоцикл
            'с' => 900,  // Літак
            'п' => 300,  // Поїзд
            _ => -1      // Невідома ознака
        };

        if (maxSpeed != -1)
        {
            Console.WriteLine($"Максимальна швидкість: {maxSpeed} км/год");
        }
        else
        {
            Console.WriteLine("Невідома ознака транспортного засобу.");
        }
    }
}

