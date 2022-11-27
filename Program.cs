
using AdvancedExamRestoran;
using AdvancedExamRestoran.Repositories;

DrinksRepository drinksRepository = new DrinksRepository();
FoodRepository foodRepository = new FoodRepository();
OrderRepository orderRepository = new OrderRepository();
TablesRepository tablesRepository = new TablesRepository();
ProductsRepository ProductsRepository = new ProductsRepository();


bool working = true;

while (working)
{
    Console.WriteLine("[1]Create order \n[2]Bill for customer [3]Bill for restaurant \n[4]Set table free \n[5]Quit");
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
                
              
                break;
            }
        case 3:
            {
                
                break;
            }
        case 4:
            {
                tablesRepository.ShowTables();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Enter table id to set it free:");
                int tableId = int.Parse(Console.ReadLine());
                tablesRepository.SetTableStatusToFree(tablesRepository.ReadTablesFromFileForStatusChange(), tableId);
                Console.WriteLine($"Table: {tableId} Status changed to free.");
                break; 
            }
        case 5:
            {
                Console.WriteLine("Goodbye!");
                working = false;
                break;
            }
        case 6:
            {
               
                break;
            }
        default:
            {
                Console.WriteLine("Wrong meniu number, please re-enter!");
                break;
            }
    }
}
