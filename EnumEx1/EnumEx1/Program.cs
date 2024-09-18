class Program
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
        Level myVar2 = Level.High;
        Console.WriteLine(myVar);
        Console.WriteLine(myVar2);
    }
}