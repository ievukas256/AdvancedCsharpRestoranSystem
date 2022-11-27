using AdvancedExamRestoran.Entities;
using Newtonsoft.Json;

namespace AdvancedExamRestoran.Repositories
{
    public class OrderRepository
    {
        ProductsRepository ProductsRepository = new ProductsRepository();
        TablesRepository TablesRepository = new TablesRepository();

        private List<Order> orders { get; set; } = new List<Order>();
        public OrderRepository()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\sibai\\Desktop\\mokslai\\Visual studio\\AdvancedExamRestoran\\DataFiles\\OrdersData.json"))
            {
                string json = r.ReadToEnd();
                orders = JsonConvert.DeserializeObject<List<Order>>(json);
            }
        }
        public Order Retrieve(int orderId)
        {
            return orders.FirstOrDefault(x => x.OrderId == orderId);
        }
        public void CreateOrder()
        {
            Console.WriteLine("Enter table ID:");
            int tableId = int.Parse(Console.ReadLine());
            int id = orders.Max(x => x.OrderId);
            int orderId = id + 1;
            DateTime date = DateTime.Now;

            var food = new List<Food>();
            var drinks = new List<Drinks>();
            var tables = new List<Tables>();
            List<OrderedProducts> orderedProducts = new List<OrderedProducts>();
         
            if (food != null && drinks != null)
            {
                bool finishOrder = false;
                while (!finishOrder)
                {
                    Console.WriteLine("[1] Add Product [2] Finish Order");
                    int input2 = int.Parse(Console.ReadLine());
                   
                    if (input2 == 1)
                    {
                        Console.WriteLine("Enter product id:");
                        int itemId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter product quantity:");
                        int qty = int.Parse(Console.ReadLine());

                        orderedProducts.Add(new OrderedProducts()
                        {
                            ProductName = ProductsRepository.RetrieveProductName(itemId),
                            ProductPrice = ProductsRepository.RetrieveProductPrice(itemId),
                            Quantity = qty,
                            Price = Math.Round(qty * ProductsRepository.RetrieveProductPrice(itemId))
                        });
                    }
                    if (input2 == 2)
                    {
                        finishOrder = true;
                    }
                }
            }
            double totalBillPrice = Math.Round(orderedProducts.Sum(x => x.Price));
            Console.WriteLine($"Order is created, order id is: {orderId}");

            orders.Add(new Order(orderId, tableId, orderedProducts, totalBillPrice, date));
            AddOrderToFile(new Order(orderId, tableId, orderedProducts, totalBillPrice, date));
            TablesRepository.ChangeTablesStatus(TablesRepository.ReadTablesFromFileForStatusChange(), tableId);
            }

            public void AddOrderToFile(Order newOrder)
            {
                string path = @"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\OrdersData.json";
                var jsonString = File.ReadAllText(path);
                var list = JsonConvert.DeserializeObject<List<Order>>(jsonString);
                list.Add(newOrder);
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(path, convertedJson);
            }
        }
}
