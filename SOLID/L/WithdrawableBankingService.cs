namespace SOLID.L;

public class WithdrawableBankingService
{
    private WithdrawableAccount _account;

    public WithdrawableBankingService(WithdrawableAccount account)
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