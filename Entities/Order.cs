using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Entities
{
    public class Order: Products
    {
        public int TableId { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; }
    }
}
