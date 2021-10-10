using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = 11;
            b = 9;
            c = 10;

            double x, y;
            Console.WriteLine("Type x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type y:");
            y = Convert.ToDouble(Console.ReadLine());

            double t1;
            double t11, t12;
            double t121, t122;
            t11 = 1 / (a*a*c*c + b*b);
            t121 = c * Math.Log(b + c*x);
            t122 = c / 2 * Math.Log(y);
            t12 = t121 - t122;
            t1 = t11 * t12;

            double t2;
            double t21, t22;
            t21 = 1 / a;
            t22 = Math.Log((1 + Math.Cos(a * x)) / (a*x));
            t2 = t21 * t22;

            Console.WriteLine($"t1 = {t1}; t2 = {t2}");
        }
    }
}
