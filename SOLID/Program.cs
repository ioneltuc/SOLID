using SOLID.S;
using SOLID.S_violation;

//Single Responsibility Violation
var st1 = new SOLID.S_violation.Student(1, "Bob", "Bob", "bob.bob@gmail.com", 7.66);
st1.SetStudiesType();
st1.SendEmail("Maine nu faceti lectii!");
st1.PrintInfoToConsole();

//Single Responsibility
var st2 = new SOLID.S.Student(2, "John", "John", "john.john@gmail.com", 9.25);
var storage = new StudentsStorage();
storage.AddStudent(st2);
storage.SetStudentStudiesType(st2.Id);
EmailSender.Send(st2.Email, "Maine nu faceti lectii!");
ConsolePrinter.PrintInfoToConsole(st2);