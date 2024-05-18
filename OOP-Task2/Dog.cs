
namespace OOP_Task2
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, string breed, string color) : base(name, age, breed, color)
        {
            
        }

        public override string MakeSound()
        {
            return "Hav Hav";
        }
    }
}
