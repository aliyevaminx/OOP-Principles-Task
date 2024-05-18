using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Electronic : Product
    {
        private string material;

        public string Material { get; }

        public Electronic(string name, int price, string material) : base (name, price)
        {
            Material = material;
        }

        public override string GetDetails()
        {
            return $"{Name} Price - {Price}$, Material - {Material}";
        }
    }
}
