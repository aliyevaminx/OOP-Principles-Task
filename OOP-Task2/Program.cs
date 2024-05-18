using OOP_Task2;

class Program
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat("Cahangir", 2, "Növü", "Narıncı");
        Dog dog = new Dog("Quli", 3, "Husky", "Qara");
        Console.WriteLine($"{cat.Name} {cat.Age} {cat.Breed} {cat.Color} {cat.MakeSound()}");
        Console.WriteLine($"{dog.Name} {dog.Age} {dog.Breed} {dog.Color} {dog.MakeSound()}");
    }
}