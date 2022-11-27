using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
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
        public void ShowTables()
        {
            foreach (Tables item in tables)
            {
                Console.WriteLine($"Table: {item.TableId} - Seats: {item.TableSeats} - Is free: {item.IsFreeTable}");
            }
        }
        public List<Tables> ChangeTablesStatus(string json, int tableId)
        {
            var tables = JsonConvert.DeserializeObject<List<Tables>>(json);
            tables.Where(w => w.TableId == tableId).ToList().ForEach(f => f.IsFreeTable = false);
            
            string path = @"C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\TablesData.json";
            var convertedJson = JsonConvert.SerializeObject(tables, Formatting.Indented);
            File.WriteAllText(path, convertedJson);
            return tables;
        }
        public List<Tables> SetTableStatusToFree(string json, int tableId)
        {
            var tables = JsonConvert.DeserializeObject<List<Tables>>(json);
            tables.Where(x => x.TableId == tableId).ToList().ForEach(x => x.IsFreeTable = true);

            string path = @"C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\TablesData.json";
            var convertedJson = JsonConvert.SerializeObject(tables, Formatting.Indented);
            File.WriteAllText(path, convertedJson);
            return tables;
        }
        public string ReadTablesFromFileForStatusChange()
        {
            string path = @"C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\TablesData.json";
            var json = File.ReadAllText(path);
            return json;
        }
       
    }
}
