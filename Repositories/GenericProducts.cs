using Newtonsoft.Json;

namespace AdvancedExamRestoran.Repositories
{
    public class GenericProducts<T>
    {
        private List<T> orderedProducts { get; set; } = new List<T>();

        public GenericProducts(List<T> list)
        {
            orderedProducts = list;
        }
        public void AddList(List<T> list)
        {
            orderedProducts.AddRange(list);
        }
        public T GetProductById(int itemId)
        {
            string path = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\DrinksData.json";
            string path2 = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\FoodData.json";
            var json = File.ReadAllText(path);
            var json2 = File.ReadAllText(path2);
            var list = JsonConvert.DeserializeObject<List<T>>(json);
            var list2 = JsonConvert.DeserializeObject<List<T>>(json2);
            list.AddRange(list2);
            return list.FirstOrDefault(x => x.Equals(itemId));
        }
        public T Retrieve(T itemId)
        {
            return orderedProducts.FirstOrDefault(x => x.Equals(itemId));
        }
    }
}