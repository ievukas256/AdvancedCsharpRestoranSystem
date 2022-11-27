using AdvancedExamRestoran.Entities;
using AdvancedExamRestoran.Interfaces;
using Newtonsoft.Json;

namespace AdvancedExamRestoran.Repositories
{
    public class FoodRepository : IProducts
    {
        private List<Food> foods { get; set; } = new List<Food>();
        public FoodRepository()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\FoodData.json"))
            {
                string json = r.ReadToEnd();
                foods = JsonConvert.DeserializeObject<List<Food>>(json);
            }
        }
        public void ShowProducts()
        {
            foreach (Food item in foods)
            {
                Console.WriteLine($"Meal: {item.ProductId} - {item.ProductName}");
            }
        }
        public Food Retrieve(int itemId)
        {
            return foods.FirstOrDefault(x => x.ProductId == itemId);
        }
    }
}
