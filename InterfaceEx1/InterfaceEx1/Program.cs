public interface IExample
{
    void Method1();
    int Property1 { get; set; }
}
public class ExampleClass : IExample
{
    public void Method1()
    {
        Console.WriteLine("Method1 implementation");
    }

    public int Property1 { get; set; }
}

class Program
{
    static void Main()
    {
        IExample example = new ExampleClass();
        example.Method1();
        example.Property1 = 10;
        Console.WriteLine(example.Property1);
    }
}