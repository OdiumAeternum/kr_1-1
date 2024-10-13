using System;

namespace kr_1_1
{
    class Program
    {
        static int Factorial(int n)
        {
            int res = 1;
            while (n != 0)
            {
                res *= n;
                n--;
            }
            return res;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Результат выражения: " + (x - Math.Pow(x, 3) / Factorial(3) + Math.Pow(x, 5) / Factorial(5) - Math.Pow(x, 7) / Factorial(7) + Math.Pow(x, 9) / Factorial(9) - Math.Pow(x, 11) / Factorial(11) + Math.Pow(x, 13) / Factorial(13)));
        }
    }
}
