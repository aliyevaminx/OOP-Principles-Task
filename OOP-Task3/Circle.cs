namespace OOP_Task3
{
    internal class Circle : Shape
    {
        private int radius;

        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value > 0) this.radius = value;
            }
        }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void GetFigureArea()
        {
            Console.WriteLine(Math.PI * (Radius * Radius));
        }
    }
}
