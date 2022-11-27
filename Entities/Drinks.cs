
namespace AdvancedExamRestoran.Entities
{
    public class Drinks : Products
    {
        public bool IsAlcohol { get; set; }
        public Drinks(int productId, string productName, double productPrice, bool isAlcohol) : base(productId, productName, productPrice)
        {
            IsAlcohol = isAlcohol;
        }
    }
}