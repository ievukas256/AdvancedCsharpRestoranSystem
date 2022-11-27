using AdvancedExamRestoran.Entities;
using System.Text.Json;

namespace AdvancedExamRestoran.Repositories
{
    public class CustomerReportRepository
    {
        public string CreateCustomerReport(int orderId)
        {
            using (StreamReader r = new StreamReader(@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\OrdersData.json"))
            {
                string json = r.ReadToEnd();
                var ordersList = JsonSerializer.Deserialize<List<CustomerReportItems>>(json);
                foreach (var items in ordersList)
                {
                    if (items.OrderId == orderId)
                    {
                        Console.WriteLine("BILL FOR CUSTOMER");
                        Console.WriteLine($"Table {items.TableId}, Order number {items.OrderId}, Date {items.Date},Product {items.ProductName},Product Quantity {items.ProductQty} pcs, Product price {items.ProductPrice} eur, Total Price {items.TotalPrice} eur ");
                    }
                }
                var list = ordersList.Where(x => x.OrderId == orderId).ToList();
                if (list.Count != 0)
                {
                    string file = (@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\CustomerBill.json");
                    string jsonString = JsonSerializer.Serialize(list);
                    File.WriteAllText(file, jsonString);
                    Console.WriteLine("JSON report created.");
                    return file;
                }
                else
                {
                    Console.WriteLine("Table ordered nothing");
                    return null;
                }
            }
        }
        public string GetHtmlFromCustomerBill(string file)
        {
            var json = File.ReadAllText(file);
            var list = JsonSerializer.Deserialize<List<CustomerReportItems>>(json);
         
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc; font-size: 12pt' >";
            html += "<h3>Bill for Customer:</h3>";
            html += "<tr>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Order Id </th>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Table ID</th>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Product Name</th>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Product Quantity</th>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Product Price,eur</th>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Total Price,eur</th>";
            html += "<th style='background-color: #A05D4E;border: 1px solid #ccc'>Date</th>";
            html += "</tr>";

            foreach (var item in list)
            {
                html += "<tr>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.OrderId + "</td>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.TableId + "</td>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.ProductName + "</td>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.ProductQty + "</td>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.ProductPrice + "</td>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.TotalPrice + "</td>";
                html += "<td style='width:120px;border: 1px solid #ccc'>" + item.Date + "</td>";
                html += "</tr>";
            }
            html += "</table>";

            File.WriteAllText(@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\CustomerBill.html", html);
            Console.WriteLine("Html file created.");
            var path = (@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\CustomerBill.html");
            return path;
        }
    }
}
