using System;

namespace MyApplication
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make sound.");
        }
    }

    class  Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: ghew ghew");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: Mew Mew");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound();
        }
    }
}