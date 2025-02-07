using System;

class Program
{
    static void Main()
    {
        double distance = 10;
        double totalDistance = 0;

        for (int i = 1; i <= 7; i++)
        {
            totalDistance += distance;
            distance *= 1.1;
        }

        Console.WriteLine($"Суммарное расстояние за 7 дней: {totalDistance} км");
    }
}