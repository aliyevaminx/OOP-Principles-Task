namespace OOP_Task2
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, string breed, string color) : base(name, age, breed, color)
        {
            
        }

        public override string MakeSound()
        {
            return "Miavvv";
        }
    }
}
