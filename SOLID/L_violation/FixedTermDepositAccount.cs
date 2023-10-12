namespace SOLID.L_violation;

public class FixedTermDepositAccount : Account
{
    public override void Deposit(double amount)
    {
        _balance += amount;
    }

    public override void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawals are not supported by Fixed Term Deposit Account!");
        throw new NotImplementedException();
    }
}