// See https://aka.ms/new-console-template for more information



using System.Xml;

Console.WriteLine("Choose a option.");
Console.WriteLine("1, Add employee");
Console.WriteLine("2, Udate employee");
Console.WriteLine("3, Delelte employee");
string sectAc = Console.ReadLine();

While(sectAc != "99");

{
    switch (sectAc)
    {
        case "1":
            Console.WriteLine("Adding a new employee");
            break;
        case "2":
            Console.WriteLine("Updading employee");
            break;

        case "3":
            Console.WriteLine("Deleting employee");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }

    Console.WriteLine("Choose the action you wnat to do:");
    Console.WriteLine("1, Add employee");
    Console.WriteLine("2, Update employee");
    Console.WriteLine("3, delete employee");
    Console.WriteLine("99. exit");
    sectAc = Console.ReadLine();
}

Console.WriteLine("Consol ap");

