using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Repositories
{
    public class FoodRepository
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
    }
}
