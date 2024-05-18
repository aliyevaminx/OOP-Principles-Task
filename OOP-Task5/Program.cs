using OOP_Task5;

class Program
{
    public static void Main(string[] args)
    {
        Order order = new();

        Electronic phone1 = new Electronic("Samsung", 400, "Plastic");
        Electronic phone2 = new Electronic("Iphone", 700, "Plastic");
        Clothes cloth1 = new Clothes("T-Shirt", 20, "XL");
        Clothes cloth2 = new Clothes("Pants", 20, "XL");
        Clothes cloth3 = new Clothes("Trousers", 20, "XL"); 
        Electronic phone3 = new Electronic("Nokia", 400, "Plastic");
        Electronic phone4 = new Electronic("Xiaomi", 700, "Plastic");
        Clothes cloth4 = new Clothes("Glasses", 20, "XL");
        Clothes cloth5 = new Clothes("Socks", 20, "XL");
        Clothes cloth6 = new Clothes("Cap", 20, "XL");

        order.AddProduct(phone1);
        order.AddProduct(phone2);
        order.AddProduct(cloth1);
        order.AddProduct(cloth2);
        order.AddProduct(cloth3); 
        order.AddProduct(phone3);
        order.AddProduct(phone4);
        order.AddProduct(cloth4);
        order.AddProduct(cloth5);
        order.AddProduct(cloth6);
        Console.WriteLine(order.GetDetails());
        order.RemoveProduct(cloth3);
        order.RemoveProduct(cloth1);
        Console.WriteLine(order.GetDetails());
        order.GetTotalAmount();
    }
}