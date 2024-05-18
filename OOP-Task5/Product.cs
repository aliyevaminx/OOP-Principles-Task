using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public int Price { get; }

        public virtual string GetDetails()
        {
            return $"{Name} {Price}";
        }
    }
}
