namespace OOP_Task3
{
    internal class Square : Shape
    {
        private int side;

        public int Side
        {
            get
            {
                return this.side;
            }
            set
            {
                if (value > 0) this.side = value;
            }
        }

        public Square(int side)
        {
            Side = side;
        }

        public override void GetFigureArea()
        {
            Console.WriteLine(Side * Side);
        }
    }


}
