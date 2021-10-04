using System;

namespace _4
{
    enum month
    {
        January,
        Febryary,
        March,
        April,
        May,
        Juni,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int day;
            bool is_leap;
            int[] days_month = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] days_month_leap = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Print year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Print day");
            day = Convert.ToInt32(Console.ReadLine());

            if (day > 366 || day < 1)
            {
                Console.WriteLine("ERRROR");
                return;
            }

            if (year % 4 == 0 && year % 100 != 0 && year % 400 != 0) {
                is_leap = true;
            } else {
                is_leap = false;
            }

            int day_cnt;
            day_cnt = day;
            int month_num;
            month_num = 0;

            if (is_leap) {
                while (month_num < 11)
                {
                    if (days_month_leap[month_num] - day_cnt > 0 && day_cnt <= days_month_leap[month_num])
                    {
                        break;
                    }
                    day_cnt -= days_month_leap[month_num];
                    month_num++;
                }
            } else {
                while (month_num < 11)
                {
                    if (days_month[month_num] - day_cnt > 0 && day_cnt <= days_month[month_num])
                    {
                        break;
                    }
                    day_cnt -= days_month[month_num];
                    month_num++;
                }
            }

            Console.WriteLine(day_cnt);
            Console.WriteLine((month)month_num);
        }
    }
}
