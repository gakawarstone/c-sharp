using System;

namespace _3._1_hw
{
    class Program
    {
        enum uni { KGU, KSTU, KAI }

        struct employer
        {
            public string name;
            public uni uni;
        }
        static void Main(string[] args)
        {
            employer Ivan;
            Ivan.name = "Ivan";
            Ivan.uni = (uni)1;
            Console.WriteLine($"Name: {Ivan.name}");
            Console.WriteLine($"Uni: {Ivan.uni}");
        }
    }
}
