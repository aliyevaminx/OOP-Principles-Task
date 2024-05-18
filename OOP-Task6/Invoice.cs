using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task6
{
    internal class Invoice
    {
        private string account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private decimal price;

        public string Account { get; }
        public string Customer { get; }
        public string Provider { get; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice(string account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public string CostCalculation(bool needEdv)
        {
            decimal totalWithoutEdv = Price * Quantity;
            decimal total = totalWithoutEdv + Convert.ToDecimal(Convert.ToDouble(totalWithoutEdv) * 0.18);

            if (needEdv)
                return $"Product: {Article} Quantity: {Quantity} Total with Edv: {total}";

            else
                return $"Product: {Article} Quantity: {Quantity} Total without Edv: {totalWithoutEdv}";

        }

    }
}
