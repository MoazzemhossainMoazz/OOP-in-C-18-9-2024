﻿
class Car
{
    public string model;

    public Car()
    {
        model = "Mustang";
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
    }
}