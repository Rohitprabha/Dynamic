using System;

namespace Dynamic_vs_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3.14f;
            //b = "Rohit";                                //Cannot implicitly convert type 'string' to 'float'
            dynamic c = 10;
            dynamic d = 3.14f;
            d = "Rohit";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
