using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Clothes : Product
    {
        private string size;

        public string Size { get; }

        public Clothes(string name, int price, string size ) : base( name, price )
        {
            Size = size;
        }

        public override string GetDetails()
        {
            return $"{Name} Price - {Price}$, Size - {Size}";
        }

       
    }
}
