using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvancedExamRestoran.Entities
{
    public class Order 
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public List<OrderedProducts> OrderedProducts { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; }
        
        public Order(int orderId, int tableId, List<OrderedProducts> orderedProducts,double totalPrice, DateTime date)
        {
            TableId = tableId;
            OrderId = orderId;
            OrderedProducts = orderedProducts;
            TotalPrice = totalPrice;
            Date = date;
        }
       
       /* public Order(List<T> orderList)
        {
            OrderList = orderList;
        }
        public void AddItemToOrder(T item)
        {
            OrderList.Add(item);
        }
        public void AddListToOrder(List<T> orderList)
        {
            OrderList.AddRange(orderList);
        }
        public void AddProductsToListById(T element)
        {
            Validation<T>.CheckIfTValueIsNotNull(element);

            var itemToAdd = OrderList.Single(x => x.Equals(element));
            OrderList.Add(itemToAdd);
        }*/
       
    }
    
}
