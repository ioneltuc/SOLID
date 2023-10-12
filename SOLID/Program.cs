using SOLID.O;

//Open-Closed Violation
var e1 = new SOLID.O_violation.Employee(1, "Bob", "Bob", "backend");
e1.SomeLogicDependingOnTheRole();

//Open-Closed
var e2 = new SOLID.O.Employee(2, "John", "John", new BackendRole());
e2.SomeLogicDependingOnTheRole();