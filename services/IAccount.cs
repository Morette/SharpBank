using Account.Enums;
using models;

namespace services
{
  public interface IAccount
  {
    public void Create(AccountType accountType, Client client, double balance);
    public void Deposit(BankAccount bank, double ammount);
    public void Withdrawal(BankAccount bank, double value);
  }
}