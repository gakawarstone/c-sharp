using System;

namespace _2._2_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            float d, d_sqrt;
            float x1, x2;

            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("print a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("print b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("print c");
            c = Convert.ToInt32(Console.ReadLine());

            d = b*b - 4*a*c;
            d_sqrt = MathF.Sqrt(d);

            if (d > 0) {
                x1 = (-b + d_sqrt) / 2 * a;
                x2 = (-b - d_sqrt) / 2 * a;
                Console.WriteLine($"x1: {x1}; x2: {x2}");
            } else if (d == 0) {
                x1 = (-b) / 2 * a;
                x2 = (-b) / 2 * a;
                Console.WriteLine($"x1: {x1}; x2: {x2}");
            } else if (d < 0) {
                Console.WriteLine("haven't x1 x2");
            } else {
                Console.WriteLine("ERRROR");
            }
        }
    }
}
