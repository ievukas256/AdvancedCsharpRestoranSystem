using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Entities
{
    public class Food : Products
    {
        public Food(int productId, string productName, double productPrice) : base(productId, productName, productPrice)
        {

        }
    }
}
