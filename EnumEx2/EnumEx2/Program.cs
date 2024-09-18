class Program
{
    enum Month
    {
        January,
        February,
        March,
        April,
        May, 
        June,
        July
    }
    static void Main(string[] args)
    {
        int myNum = (int)Month.April;
        Month myNum2 = Month.June;
        int myNum3 =(int) Month.May;
        Console.WriteLine(myNum);
        Console.WriteLine(myNum2);
        Console.WriteLine(myNum3);
    }
}