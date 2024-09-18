using System;
namespace ParameterizedConstructorExample
{
    class Geek
    {
        String name;
        int id;


        Geek(String name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public static void Main()
        {
            Geek geek1 = new Geek("GFG", 1);
            Console.WriteLine("GeekName= " + geek1.name + "and Geekid =" + geek1.id);
        }
    }
}