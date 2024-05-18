using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    internal class Order
    {
        private Product[] products;
        private int count;

        public Order()
        {
            Products = new Product[11];
            Count = 0;
        }

        public int Count { get; set; }
        internal Product[] Products { get; }

        public void AddProduct(Product product)
        {
            if (Count < Products.Length - 1)
            {
                Products[Count] = product;
                Count++;
            } 
            else
            {
                Console.WriteLine("You have reached order limit.");
            }
        }

        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(Products, product);

            if (index != -1)
            {
                for (int i = index; i < Count; i++)
                {
                    Products[i] = Products[i + 1];
                }
                Count--;
            } else
            {
                Console.WriteLine("Product is not found.");
            }
        }

        public string GetDetails()
        {
            string productDetails = String.Empty;

            for (int i = 0; i < Count; i++ )
            {
                productDetails += Products[i].GetDetails() + "\n";
            }

            return productDetails;
        }

        public void GetTotalAmount()
        {
            int total = 0;

            for (int i = 0;i < Count;i++)
            {
                total += Products[i].Price;
            }

            Console.WriteLine($"Total Amount: {total}$"); ;
        }
    }
}
