using Microsoft.Win32;
using System;

namespace Pr2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = 0;
            if (x > 3.6)  y = 45*Math.Pow(x,2) + 5;
            else y = (5*x) / (10*Math.Pow(x, 12) + 1);
            Console.WriteLine("Для x = {0:f4} ", x);
            Console.WriteLine("Результат = {0:f4}" + y);

        }
    }
}
