using System;

namespace Dynamic_Demo
{
    public class Student
    {
        public void DisplayStudentInfo(int id)
        {
            Console.WriteLine("StudentInfo Method is called");
        }
    }
    class Program
    {
        public static void Add(dynamic s1, dynamic s2)               // Method which contains dynamic parameters
        {
            Console.WriteLine(s1 + s2);
        }
        static void Main(string[] args)
        {
            dynamic d1, d2, d3;
            d1 = 10;
            d2 = 20;
            d2 = "20";
            d3 = d1 + d2;
            Console.WriteLine(d3);

            Add("a", "b");
            Add("Rohit ", "Dasari");
            Add("Hello", 123);
            Add(10, 20);

            dynamic stud = new Student();

            stud.DisplayStudentInfo(1, "Rohit");                // run-time error, no compile-time error
            stud.DisplayStudentInfo("1");                       // run-time error, no compile-time error
            stud.FakeMethod();                                  // run-time error, no compile-time error
            stud.DisplayStudentInfo(1);

        }
    }
}
