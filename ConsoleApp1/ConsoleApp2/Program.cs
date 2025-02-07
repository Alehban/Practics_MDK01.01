using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите d");
            double d = Convert.ToDouble(Console.ReadLine());
            double result = (a / b) / (c / d);
            Console.WriteLine("Для дробей {0}/{1} и {2}/{3} ", a, b, c, d);
            Console.WriteLine("Результат = {0:f4}", result);
        }
    }
}
