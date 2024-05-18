namespace OOP_Task2
{
    internal abstract class Animal
    {
        private string name;
        private int age;
        private string breed;
        private string color;

        public Animal(string name, int age, string breed, string color)
        {
            Name = name;
            Age = age;
            Breed = breed;
            Color = color;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        abstract public string MakeSound();
     
    }
}
