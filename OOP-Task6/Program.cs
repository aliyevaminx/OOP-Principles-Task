using OOP_Task6;

class Program
{
    public static void Main(string[] args)
    {
        Invoice inv = new Invoice("53252", "Amin", "Samsung");
        inv.Article = "USB-Hab";
        inv.Quantity = 5;
        inv.Price = 27;
        Console.WriteLine(inv.CostCalculation(false));
    }
}