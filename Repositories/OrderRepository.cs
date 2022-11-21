using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Repositories
{
    public class OrderRepository
    {
        private List<Order> orders { get; set; } = new List<Order>();
        public OrderRepository()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\OrdersData.json"))
            {
                string json = r.ReadToEnd();
                orders = JsonConvert.DeserializeObject<List<Order>>(json);
            }
        }
    }
}
