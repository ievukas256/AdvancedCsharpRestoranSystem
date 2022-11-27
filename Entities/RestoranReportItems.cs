
namespace AdvancedExamRestoran.Entities
{
    public class RestoranReportItems
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; }
        public RestoranReportItems(int orderId, int tableId, double totalPrice, DateTime date)
        {
            OrderId = orderId;
            TableId = tableId;
            TotalPrice = totalPrice;
            Date = date;
        }
        public RestoranReportItems()
        {

        }
    }
}
