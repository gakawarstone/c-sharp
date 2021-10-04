using System;

namespace _2._1_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;

            key = Console.ReadKey();
            Console.WriteLine(Convert.ToChar(Convert.ToInt32(key) + 1));
        }
    }
}
