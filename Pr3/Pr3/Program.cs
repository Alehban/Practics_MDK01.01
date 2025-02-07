using System;


namespace Pr3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите n");
            uint n;
            int i;
            n = Convert.ToUInt32(Console.ReadLine());
            double S = 0;
            for (i = 1; i <= n; i++) { S += Math.Pow(n, 7); i++; }
            Console.WriteLine("Результат ={0}", S);
        }
    }
}

