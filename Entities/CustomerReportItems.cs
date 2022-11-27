
namespace AdvancedExamRestoran.Entities
{
    public class CustomerReportItems
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public string ProductName { get; set; }
        public int ProductQty { get; set; }
        public double ProductPrice { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; }
        public CustomerReportItems(int orderId, int tableId, string productName,int productQty, double productPrice, double totalPrice, DateTime date)
        {
            OrderId = orderId;
            TableId = tableId;
            ProductName = productName;
            ProductQty = productQty;
            ProductPrice = productPrice;
            TotalPrice = totalPrice;
            Date = date;
        }
    }
}
