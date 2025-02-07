using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите единицу измерения(1 – дециметр, 2 – километр, 3 – миллиметр, 4 - сантиметр): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка: ");
            double L = Convert.ToDouble(Console.ReadLine());

            switch (x)
            {
                case 1: Console.WriteLine("Длина отрезка в метрах={0}", L / 10); break;
                case 2: Console.WriteLine("Длина отрезка в метрах={0}", L * 1000); break;
                case 3: Console.WriteLine("Длина отрезка в метрах={0}", L / 1000); break;
                case 4: Console.WriteLine("Длина отрезка в метрах={0}", L / 100); break;
            }
        }
    }
}
