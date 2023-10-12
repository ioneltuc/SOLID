using SOLID.L;
using SOLID.L_violation;
using FixedTermDepositAccount = SOLID.L_violation.FixedTermDepositAccount;

//Liskov Substitution Violation
var bankService1 = new BankingService(new FixedTermDepositAccount());
// bankService1.Withdraw(2000); //Exception

//Liskov Substitution
var bankService2 = new WithdrawableBankingService(new SOLID.L.PersonalAccount());
bankService2.Withdraw(2000);
