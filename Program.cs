
using AdvancedExamRestoran;
using AdvancedExamRestoran.Repositories;

DrinksRepository drinksRepository = new DrinksRepository();
FoodRepository foodRepository = new FoodRepository();
OrderRepository orderRepository = new OrderRepository();
TablesRepository tablesRepository = new TablesRepository();
RestoranReportRepository restoranReportRepository = new RestoranReportRepository(); 
CustomerReportRepository customerReportRepository = new CustomerReportRepository();
Email email = new Email();
MailGeneration mailGeneration = new MailGeneration(email);


bool working = true;

while (working)
{
    Console.WriteLine("[1]Create order \n[2]Bill for customer [3]Bill for restaurant [4]Send bills to email\n[5]Set table free \n[6]Quit");
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            {
                drinksRepository.ShowProducts();
                foodRepository.ShowProducts();
                tablesRepository.ShowTables();
                orderRepository.CreateOrder();
                break;
            }
        case 2:
            {
                Console.WriteLine("Enter order ID for Customer bill");
                int orderId = int.Parse(Console.ReadLine());
                customerReportRepository.CreateCustomerReport(orderId);
                string file = (@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\CustomerBill.json");
                customerReportRepository.GetHtmlFromCustomerBill(file);
                break;
            }
        case 3:
            {
                Console.WriteLine("Enter order ID for Restaurant bill");
                int orderId = int.Parse(Console.ReadLine());
                restoranReportRepository.CreateRestoranReport(orderId);
                string file = (@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\RestaurantBill.json");
                restoranReportRepository.GetHtmlFromRestaurantBill(file);
                break;
            }
        case 5:
            {
                tablesRepository.ShowTables();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Enter table id to set it free:");
                int tableId = int.Parse(Console.ReadLine());
                tablesRepository.SetTableStatusToFree(tablesRepository.ReadTablesFromFileForStatusChange(), tableId);
                Console.WriteLine($"Table: {tableId} Status changed to free.");
                break; 
            }
        case 4:
            {
                mailGeneration.SendingBillsToEmail();
                break;
            }
        case 6:
            {
                Console.WriteLine("Goodbye!");
                working = false;
                break;
            }
        default:
            {
                Console.WriteLine("Wrong meniu number, please re-enter!");
                break;
            }
    }
}
