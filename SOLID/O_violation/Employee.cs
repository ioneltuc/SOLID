namespace SOLID.O_violation;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; }

    public Employee(int id, string firstName, string lastName, string role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Role = role;
    }

    public void SomeLogicDependingOnTheRole()
    {
        switch (Role.ToLower())
        {
            //in caz ca apare un rol nou,
            //clasa trebuie modificata
            case "frontend":
                //logic
                Console.WriteLine("Eu sunt frontend-er");
                break;
            case "backend":
                //logic
                Console.WriteLine("Eu sunt backend-er");
                break;
            default:
                Console.WriteLine("There is no such role.");
                break;
        }
    }
}
