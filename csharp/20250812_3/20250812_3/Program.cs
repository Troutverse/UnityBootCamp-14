namespace _20250812_3
{   
    abstract class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Console.WriteLine($"Hi, I`m {name}");
        }
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("야옹");
        }
    }
    class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
        }
 
        public override void MakeSound()
        {
            Console.WriteLine("음머");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Dog");
            dog.MakeSound();
            Cat cat = new Cat("Cat");
            cat.MakeSound();
            Cow cow = new Cow("Cow");
            cow.MakeSound();
        }
    }
}
