namespace SOLID.L_violation;

public abstract class Account
{
    protected double _balance;

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
}