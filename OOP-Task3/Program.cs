using OOP_Task3;

class Program
{
    public static void Main(string[] args)
    {
        Triangle triange = new Triangle(4, 5);
        Circle circle = new Circle(6);
        Square square = new Square(4);

        triange.GetFigureArea();
        circle.GetFigureArea();
        square.GetFigureArea();
    }
}