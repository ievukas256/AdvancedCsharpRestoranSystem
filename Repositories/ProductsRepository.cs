using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;

namespace AdvancedExamRestoran.Repositories
{
    public class ProductsRepository
    {
        private List<Products> AllProducts { get; set; } = new List<Products>();
        public double RetrieveProductPrice(int itemId)
        {
            string path = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\FoodData.json";
            string path2 = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\DrinksData.json";
            var jsonString = File.ReadAllText(path);
            var jsonString2 = File.ReadAllText(path2);
            var food = JsonConvert.DeserializeObject<List<Products>>(jsonString);
            var drinks = JsonConvert.DeserializeObject<List<Products>>(jsonString2);
            food.AddRange(drinks);
            var product = food.FirstOrDefault(x => x.ProductId == itemId);
            var productPrice = product.ProductPrice;

            return productPrice;
        }
        public string RetrieveProductName(int itemId)
        {
            string path = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\FoodData.json";
            string path2 = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\DrinksData.json";
            var jsonString = File.ReadAllText(path);
            var jsonString2 = File.ReadAllText(path2);
            var food = JsonConvert.DeserializeObject<List<Products>>(jsonString);
            var drinks = JsonConvert.DeserializeObject<List<Products>>(jsonString2);
            food.AddRange(drinks);
            var product = food.FirstOrDefault(x => x.ProductId == itemId);
            var productName = product.ProductName;

            return productName;
        }
    }
}
