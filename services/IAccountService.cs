using System.Collections.Generic;
using Account.Enums;
using models;

namespace services
{
  public interface IAccountService
  {
    public List<BankAccount> ListAllAccount();
    public void Create(string accountType, string clientName, string balance);
    public void Deposit(BankAccount bank, double ammount);
    public void Withdrawal(BankAccount bank, double value);
  }
}