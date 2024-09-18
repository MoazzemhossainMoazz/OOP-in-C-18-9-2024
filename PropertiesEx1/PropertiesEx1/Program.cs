using System;

public class Student
{
    private static int cnt;

    public Student()
    {
        cnt++;
    }

    public static int Counter
    {
        get
        {
            return cnt;
        }
    }
}

class StudentTest
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();
        Student s3 = new Student();

        Console.WriteLine("Total No of Student: " + Student.Counter);
    }
}