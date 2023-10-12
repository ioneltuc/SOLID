namespace SOLID.O;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IRole Role { get; set; }

    public Employee(int id, string firstName, string lastName, IRole role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Role = role;
    }

    public void SomeLogicDependingOnTheRole()
    {
        Role.Work();     
    }
}