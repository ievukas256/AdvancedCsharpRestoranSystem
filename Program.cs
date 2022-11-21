

bool working = true;

while (working)
{
    Console.WriteLine("[1]Create order \n [2]Bill for customer [3]Bill for restaurant \n[4]Quit");
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            {
              
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
                Console.WriteLine("Goodbye!");
                working = false;
                break;
            }
        case 5:
            {
                
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
