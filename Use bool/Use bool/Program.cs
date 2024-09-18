Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("too young to apply");
    Console.WriteLine("Send email to candidate.");
}
else if(age > 65)
{
    Console.WriteLine("sorry, the selected age is too old.");
    Console.WriteLine("send Email to candidate.");
}
else
{
    Console.WriteLine("Great, yuo can now start with the application.");
}
