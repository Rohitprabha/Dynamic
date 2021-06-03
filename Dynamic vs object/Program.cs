using System;

namespace Dynamic_vs_object
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diff 1
            object obj1, obj2, obj3;
            obj1 = 1;
            obj2 = 2;
            //obj3 = obj1 + obj2;                 //Operator '+' cannot be applied to operands of type 'object' and 'object'

            dynamic a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine(c);

            //Diff 2
            object obj4 = "Rohit";
            //string s = obj4;                    //Cannot implicitly convert type 'object' to 'string'.
            string s1 = obj4.ToString();
            Console.WriteLine(s1);

            dynamic d = "ABC";
            string s2 = d;
            Console.WriteLine(s2);
        }
    }
}
