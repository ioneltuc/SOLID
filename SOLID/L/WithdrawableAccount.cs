namespace SOLID.L;

public class WithdrawableAccount : SOLID.L.Account
{
    public override void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        _balance -= amount;
    }
}