using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;
using AdvancedExamRestoran.Interfaces;

namespace AdvancedExamRestoran.Repositories
{
    public class DrinksRepository :IProducts
    {
        private List<Drinks> drinks { get; set; } = new List<Drinks>();
        public DrinksRepository()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\DrinksData.json"))
            {
                string json = r.ReadToEnd();
                drinks = JsonConvert.DeserializeObject<List<Drinks>>(json);
            }
        }
        public void ShowProducts()
        {
            foreach (Drinks item in drinks)
            {
                Console.WriteLine($"Drink: {item.ProductId} - {item.ProductName}");
            }
        }
        public Drinks Retrieve(int itemId)
        {
            return drinks.FirstOrDefault(x => x.ProductId == itemId);
        }
    }
}
