using System;

namespace MyApplication
{
    class Program
    {
       
        static  int MyMethod2(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            int num = MyMethod2(5, 6);
            Console.WriteLine((num));
        }
    }
}
