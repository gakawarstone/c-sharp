using System;

namespace _5
{
    class Program
    {
        static int Max_2(int a, int b)
        {
            if (a >= b) {
                return a;
            } else {
                return b;
            }
        }

        static bool Replace(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            return true;
        }

        static int Fact(int a)
        {
            int answ;
            answ = 1;
            checked
            {
                while (a > 0)
                {
                    answ *= a;
                    a -= 1;
                }
            }

            return answ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Max_2(2, 3));

            int a = 1;
            int b = 2;

            Replace(ref a, ref b);
            Console.WriteLine($"{a}:{b}");

            Console.WriteLine(Fact(3));
        }
    }
}
