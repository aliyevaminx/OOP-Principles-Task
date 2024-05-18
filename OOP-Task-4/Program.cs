using OOP_Task_4;

class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("Audi", "RS7", "Blue", 300, 5);
        Truck truck = new Truck("Kamaz", "200", "White", 180, 200);
        car.GetDetails();
        truck.GetDetails();
    }
}