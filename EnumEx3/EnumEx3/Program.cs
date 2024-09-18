class Program
{
    enum Months
    {
        January,
        February,
        March = 6,
        April,
        May,
        June = 10,
        July
    }

    static void Main(string[] args)
    {
        int myNum = (int)Months.April;
        Console.WriteLine(myNum);
        int myNum2 = (int)Months.June;
        Console.WriteLine(myNum2);
        int myNum3 = (int)Months.July;
        Console.WriteLine(myNum3);
    }
}
