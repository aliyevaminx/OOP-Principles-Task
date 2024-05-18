
namespace OOP_Task_4
{
    internal class Truck : Vehicle
    {
        private int load;

        public int Load { get; set; }

        public Truck(string brand, string model, string color, int maxSpeed, int load) : base(brand, model, color, maxSpeed)
        {
            Load = load;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Brand} {Model} {Color} {MaxSpeed} {Load}");
        }
    }
}
