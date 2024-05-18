
namespace OOP_Task3
{
    internal class Triangle : Shape
    {
        private int height;
        private int side;

        public Triangle(int height, int side)
        {
            Height = height;
            Side = side;
        }

        public int Height { 
            get
            {
                return this.height;
            } 
            set
            {
                if (value > 0) this.height = value;
            }
        }
        public int Side { 
            get
            {
                return this.side;
            } 
            set
            {
                if (value > 0) this.side = value;   
            }
        }

        public override void GetFigureArea()
        {
            Console.WriteLine((Height * Side) / 2);
        }
    }
}
