using System.Collections.Generic;
using Account.Enums;
using models;

namespace Repository
{
  public class BankAccountRepository : IAccountRepository
  {
    private List<BankAccount> accountList = new List<BankAccount>();

    public List<BankAccount> ListAllAccount()
    {
      return accountList;
    }

    public void Create(AccountType accountType, Client client, double balance = 0)
    {
      BankAccount bank = new BankAccount(accountType, client, balance);
      accountList.Add(bank);
    }

    public void Deposit(BankAccount bank, double ammount)
    {
      BankAccount bankAccount = accountList.Find(b => b == bank);
      bankAccount.Balance += ammount;
    }

    public void Withdrawal(BankAccount bank, double value)
    {
      BankAccount bankAccount = accountList.Find(b => b == bank);
      bankAccount.Balance -= value;
    }

    public double CheckBalance(BankAccount bank)
    {
      BankAccount bankAccount = accountList.Find(b => b == bank);
      return bankAccount.Balance;
    }
  }
}