using System;

namespace _3._1
{
    enum account_type { Regular, Savings }

    class Program
    {
        static void Main(string[] args)
        {
            account_type first, second;
            first = (account_type)0;
            second = (account_type)1;
            Console.WriteLine($"first account is {first}");
            Console.WriteLine($"second account is {second}");
        }
    }
}
