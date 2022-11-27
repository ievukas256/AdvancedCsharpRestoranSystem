using AdvancedExamRestoran.Interfaces;

namespace AdvancedExamRestoran
{
    public class MailGeneration
    {
        IEmail Mail;
        public MailGeneration(IEmail mail)
        {
            Mail = mail;
        }
        public void SendingBillsToEmail()
        {
            while (true)
            {
                Console.WriteLine("[1] Send bill of customer [2] Send bill for restaurant");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Mail.SendEmail(@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\CustomerBill.html");
                    Console.WriteLine("Mail was send.");
                    break;
                }
                if (input == 2)
                {
                    Mail.SendEmail(@"C:\Users\sibai\Desktop\mokslai\Visual studio\AdvancedExamRestoran\DataFiles\RestaurantBill.html");
                    Console.WriteLine("Mail was send.");
                    break;
                }
                break;
            }
        }
    }
}
