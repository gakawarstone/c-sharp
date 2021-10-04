using System;

namespace _2._2_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int d;
            int x1, x2;

            Console.WriteLine("ax^2 + bx + c = 0");
            Console.WriteLine("print a");
            a = (int)Console.ReadLine();
            Console.WriteLine("print b");
            b = (int)Console.ReadLine();
            Console.WriteLine("print c");
            c = (int)Console.ReadLine();

            d = b**2 - 4*a*c;

            if (d > 0) {
                x1 = (-b + d**0.5) / 2*a
                x2 = (-b + d**0.5) / 2*a
                Console.WriteLine($"x1: {x1}; x2: {x2}");
            } else if (d == 0) {
                x1 = (-b) / 2*a
                x2 = (-b) / 2*a
                Console.WriteLine($"x1: {x1}; x2: {x2}");
            } else if (d < 0) {
                Console.WriteLine("haven't x1 x2");
            } else {
                Console.WriteLine("ERRROR")
            }
        }
    }
}
