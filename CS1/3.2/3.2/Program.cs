using System;

namespace _3._2
{
    enum account_type { Regular, Savings }

    struct bank_account
    {
        public int number;
        public account_type type;
        public double cash;
    }

    class Program
    {
        static void Main(string[] args)
        {
            bank_account first;
            first.number = 0;
            first.type = (account_type)0;
            first.cash = 122.22;
            Console.WriteLine($"Number: {first.number}");
            Console.WriteLine($"Type: {first.type}");
            Console.WriteLine($"Cash: {first.cash}");
        }
    }
}
