using System;

namespace _2._1_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;

            Console.WriteLine("Write letter: ");
            key = (char)Console.Read();
            key = (char)((int)key + 1);
            Console.WriteLine("Next letter is " + key);
        }
    }
}
