namespace SOLID.L_violation;

public class BankingService
{
    private Account _account;

    public BankingService(Account account)
    {
        _account = account;
    }

    public void Deposit(double amount)
    {
        _account.Deposit(amount);
    }

    public void Withdraw(double amount)
    {
        _account.Withdraw(amount);
    }
}