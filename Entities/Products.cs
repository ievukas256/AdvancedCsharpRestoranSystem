
namespace AdvancedExamRestoran.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Products(int productId, string productName, double productPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
