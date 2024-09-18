interface IFirstInterface
{
    void myMethod();
}
interface ISecondInterface
{
    void myOtherMethod();
}

class DemoClass: IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("1st interface messege...");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("2nd interface messege...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();
    }
}