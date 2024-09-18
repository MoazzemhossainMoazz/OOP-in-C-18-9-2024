using System;

namespace MyApplication
{
    class Car
    {
        string color = "green";
        int model = 30;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.model);
        }
    }
}
