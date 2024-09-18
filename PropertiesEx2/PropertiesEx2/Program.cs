using System;

public class Student
{
    private string name = "Hello bangladesh";

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

class TestStudent
{
    public static void Main(string[] args)
    {
        Student s = new Student();

        s.Name = "GFG";
        Console.WriteLine("Name: " + s.Name);
    }
}