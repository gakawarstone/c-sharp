using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            try {
                Console.WriteLine("Print a:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Print a:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Answer: " + (a / b));
            } catch {
                Console.WriteLine("ERRROR");
            }

        }
    }
}
