using System.Net.Mail;

namespace SOLID.S_violation;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public double AverageSchoolMark { get; set; }
    public StudiesType Studies { get; set; }
    
    public Student(int id, string firstName, string lastName, string email, double averageSchoolMark)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        AverageSchoolMark = averageSchoolMark;
    }

    public void SendEmail(string message)
    {
        var mail = new MailMessage();

        try
        {
            mail.To.Add(Email);
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

    public void SetStudiesType()
    {
        if (AverageSchoolMark > 8.5)
            Studies = StudiesType.Budget;
        else
            Studies = StudiesType.Contract;
    }

    public void PrintInfoToConsole()
    {
        Console.WriteLine($"Full name: {FirstName} {LastName}\n" +
                          $"Mark: {AverageSchoolMark}\n" +
                          $"Studies type: {Studies}\n");
    }
}