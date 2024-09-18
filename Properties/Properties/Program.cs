using System;

public class C1
{
    public int rn;
    public string name;
}

public class C2
{
    public static void Main(string[] args)
    {
        C1 obj = new C1();

        obj.rn = 1000;
        obj.name = "Null";
        Console.WriteLine("Name: {0} \nRoll No: {1}", obj.name, obj.rn);
    }
}