using models;

namespace Account
{
  public interface IAccount
  {
    public void Deposit(double value);
    public void Withdrawal(double value);
    public void Transfer(double ammount, BankAccount account);
  }
}