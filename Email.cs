using System.Net.Mail;
using System.Net;
using AdvancedExamRestoran.Interfaces;

namespace AdvancedExamRestoran
{
    public class Email:IEmail
    {
        public virtual string SendEmail(string file)
        {
            MailAddress to = new MailAddress("restoran@westminster.co.uk");
            MailAddress from = new MailAddress("customers@mailtrap.io");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "report";
            message.Body = "Download file";
            message.Attachments.Add(new Attachment(file));
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("6b97440f4ef486", "5130c85a0026da"),
                EnableSsl = true
            };
            // code in brackets above needed if authentication required
            try
            {
                client.Send(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return file;
        }

       
    }
}
