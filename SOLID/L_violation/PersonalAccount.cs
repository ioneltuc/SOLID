namespace SOLID.L_violation;

public class PersonalAccount : Account
{
    public override void Deposit(double amount)
    {
        _balance += amount;
    }

    public override void Withdraw(double amount)
    {
        _balance -= amount;
    }
}