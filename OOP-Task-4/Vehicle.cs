namespace OOP_Task_4
{
    internal class Vehicle
    {
        private string brand;
        private string model;
        private string color;
        private int maxSpeed;


        public Vehicle(string brand, string model, string color, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            Color = color;
            MaxSpeed = maxSpeed;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; }

        public virtual void GetDetails()
        {
            Console.WriteLine($"{Brand} {Model} {Color} {MaxSpeed}");
        }

    }
}
