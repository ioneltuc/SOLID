namespace SOLID.S;

public static class ConsolePrinter
{
    public static void PrintInfoToConsole(Student student)
    {
        Console.WriteLine($"Full name: {student.FirstName} {student.LastName}\n" +
                          $"Mark: {student.AverageSchoolMark}\n" +
                          $"Studies type: {student.Studies}\n");
    }
}