using System;

namespace Dynamic_Example_3
{
    class Program
    {
        public static void Add(dynamic s1, dynamic s2)               // Method which contains dynamic parameters
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            Add("a", "b");
            Add("Rohit ", "Dasari");
            Add("Hello", 123);
            Add(10, 20);
        }
    }
}
