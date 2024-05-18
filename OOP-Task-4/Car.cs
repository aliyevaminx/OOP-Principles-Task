namespace OOP_Task_4
{
    internal class Car : Vehicle
    {
        private int passengers;

        public int Passengers { get; set; }

        public Car(string brand, string model, string color, int maxSpeed, int passengers) : base(brand, model, color, maxSpeed)
        {
            Passengers = passengers;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Brand} {Model} {Color} {MaxSpeed} {Passengers}");
        }

    }
}
