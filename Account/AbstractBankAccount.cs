using System;
using Account.Enums;
using models;

namespace Account
{
  public abstract class AbstractBankAccount : IAccount
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

      this.Id++;
      PrintAccountCreated();
    }

    public AbstractBankAccount(AccountType accountType, Client client, double balance)
    {
      this.AccountType = accountType;
      this.Client = client;
      this.Balance = balance;

      this.Id++;
      PrintAccountCreated();
    }
    private void PrintAccountCreated()
    {
      Console.WriteLine($"Account for client {Client.Name} was successfully created with the number {Id}");
    }

    public abstract void Deposit(double value);
    public abstract void Transfer(double ammount, BankAccount account);
    public abstract void Withdrawal(double value);
  }
}