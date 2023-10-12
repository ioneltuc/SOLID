using System.Net.Mail;

namespace SOLID.D;

public class EmailNotifier : INotifier
{
    public void Notify(string message)
    {
        var mail = new MailMessage();

        try
        {
            mail.Body = message;

            using (var smtp = new SmtpClient())
            {
                smtp.Send(mail);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}