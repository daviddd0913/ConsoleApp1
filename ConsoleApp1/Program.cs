using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double meal_cost = 100;

            int tip_percent = 15;

            int tax_perent = 8;

            int x;

            x = (int)meal_cost + tip_percent + tax_perent;

            Console.WriteLine("總金額為:"+x);
        }
    }
}
