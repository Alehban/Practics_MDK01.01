using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow((x + 1 / x - 1), x) + 18 * x * Math.Pow(y, 2);
            Console.WriteLine("Для x = {0:f4} и y = {1:f4} ", x, y);
            Console.WriteLine("Результат = {0:f4}", result);

        }
    }
}
