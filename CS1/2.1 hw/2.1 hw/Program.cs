using System;

namespace _2._1_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;

            Console.WriteLine("Write letter: ");
            key = Convert.ToChar(Console.Read());
            key = Convert.ToChar(Convert.ToInt32(key) + 1);
            Console.WriteLine("Next letter is " + key);
        }
    }
}
