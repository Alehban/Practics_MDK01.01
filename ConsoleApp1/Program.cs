using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите три числа(через ENTER): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double max = 0;
            double min = 0;

            if (x > y || x > z) max = x;
            else if (y > z) max = y;
            else max = z;
            if (x < y || x < z) min = x;
            else if (y < z) min = y;
            else min = z;

            Console.WriteLine("Сумма минимального и максимального числа={0}", min+max);
        }
    }
}
