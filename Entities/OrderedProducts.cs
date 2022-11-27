using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Entities
{
    public class OrderedProducts
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public OrderedProducts(string productName, double productPrice, int quantity, double price)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Quantity = quantity;
            Price = price;
        }

        public OrderedProducts()
        {
        }
    }
}
