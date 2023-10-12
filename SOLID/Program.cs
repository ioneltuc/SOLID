using SOLID.D;
using ConsoleNotifier = SOLID.D_violation.ConsoleNotifier;
using NotificationWorker = SOLID.D_violation.NotificationWorker;

//Dependency Inversion Principle Violation
var worker = new NotificationWorker(new ConsoleNotifier());
worker.Notify("Hello");

//Dependency Inversion Principle
var worker2 = new SOLID.D.NotificationWorker(new SOLID.D.ConsoleNotifier());
worker2.Notify("Hello Console");
worker2 = new SOLID.D.NotificationWorker(new EmailNotifier());
worker2.Notify("Hello, this is an email");