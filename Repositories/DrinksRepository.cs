using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AdvancedExamRestoran.Repositories
{
    public class DrinksRepository
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
    }
}
