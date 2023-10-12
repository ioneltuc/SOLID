namespace SOLID.S;

public class StudentsStorage
{
    public List<Student> Students;

    public StudentsStorage()
    {
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void SetStudentStudiesType(int id)
    {
        var student = Students.Find(s => s.Id == id);

        if (student.AverageSchoolMark > 8.5)
            student.Studies = StudiesType.Budget;
        else
            student.Studies = StudiesType.Contract;
    }
}