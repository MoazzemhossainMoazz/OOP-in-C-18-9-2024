﻿class Program
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        switch (myVar)
        {
            case Level.Low:
                Console.WriteLine("Low level");
                break;
            case Level.Medium:
                Console.WriteLine("Medium");
                break;
            case Level.High:
                Console.WriteLine("Low");
                break;
        }
    }
}
