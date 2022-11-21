using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExamRestoran.Repositories
{
    public class TablesRepository
    {
        private List<Tables> tables { get; set; } = new List<Tables>();
        public TablesRepository()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\TablesData.json"))
            {
                string json = r.ReadToEnd();
                tables = JsonConvert.DeserializeObject<List<Tables>>(json);
            }
        }
    }
}
