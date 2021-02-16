using System;
using Account.Enums;

namespace models
{
  public abstract class AbstractBankAccount
  {
    public int Id { get; }
    public Client Client { get; }
    public double Balance { get; set; }
    public AccountType AccountType { get; }

    public AbstractBankAccount(AccountType accountType, Client client)
    {
      this.Client = client;
      this.AccountType = accountType;
      this.Balance = 0;
      this.Id = new Random().Next(1, 1000);
    }

    public AbstractBankAccount(AccountType accountType, Client client, double balance)
    {
      this.AccountType = accountType;
      this.Client = client;
      this.Balance = balance;
      this.Id = new Random().Next(1, 1000);
    }
  }
}