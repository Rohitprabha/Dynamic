using System;

namespace Dynamic_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic stud = new Student();

            stud.DisplayStudentInfo(1, "Rohit");                // run-time error, no compile-time error
            stud.DisplayStudentInfo("1");                       // run-time error, no compile-time error
            stud.FakeMethod();                                  // run-time error, no compile-time error
            stud.DisplayStudentInfo(1);
        }
    }
    public class Student
    {
        public void DisplayStudentInfo(int id)
        {
            Console.WriteLine("StudentInfo Method is called");
        }
    }
}
