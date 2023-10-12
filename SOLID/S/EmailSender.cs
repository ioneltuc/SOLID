using System.Net.Mail;

namespace SOLID.S;

public static class EmailSender
{
    public static void Send(string toEmail, string message)
    {
        var mail = new MailMessage();

        try
        {
            mail.To.Add(toEmail);
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