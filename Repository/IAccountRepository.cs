using System.Collections.Generic;
using Account.Enums;
using models;

namespace Repository
{
  public interface IAccountRepository
  {
    public List<BankAccount> ListAllAccount();
    public void Create(AccountType accountType, Client client, double balance);
    public void Deposit(BankAccount bank, double ammount);
    public void Withdrawal(BankAccount bank, double value);
  }
}