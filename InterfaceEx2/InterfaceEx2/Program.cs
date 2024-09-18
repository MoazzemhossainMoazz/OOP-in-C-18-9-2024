public interface IAnimal
{
    void MakeSound();
}

public interface IWalk
{
    void Walk();
}
public class Dog : IAnimal, IWalk
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public void Walk()
    {
        Console.WriteLine("Dog is walking");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Walk();
    }
}