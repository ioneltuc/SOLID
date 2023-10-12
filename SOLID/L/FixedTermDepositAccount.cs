namespace SOLID.L;

public class FixedTermDepositAccount : Account
{
    public override void Deposit(double amount)
    {
        _balance += amount;
    }
}