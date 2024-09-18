using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod1()
        {
            Console.WriteLine("I just got executed!");
        }

        static void MyMethod2(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        static void MyMethod3(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            Console.WriteLine("sum:" + sum);
        }

        static void Main(string[] args)
        {
            MyMethod1();
            MyMethod2(5, 6);
            MyMethod3(5, 6, 7);
        }
    }
}