using System;

namespace Dynamic_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d1, d2, d3;
            d1 = 10;
            d2 = 20;
            d2 = "20";
            d3 = d1 + d2;
            Console.WriteLine(d3);
        }
    }
}
