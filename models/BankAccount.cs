using System;
using System.Collections.Generic;
using Account;
using Account.Enums;

namespace models
{
  public class BankAccount : AbstractBankAccount
  {
    private List<BankAccount> accountList = new List<BankAccount>();

    public BankAccount(AccountType accountType, Client client) : base(accountType, client)
    {
      accountList.Add(this);
    }

    public BankAccount(AccountType accountType, Client client, double balance) : base(accountType, client, balance)
    {
      accountList.Add(this);
    }

    public override void Deposit(double value)
    {
      this.Balance += value;
      Console.WriteLine($"US${value} deposited.\n" +
      $"{Client.Name} actual balance is US${Balance}");
    }

    public override void Withdrawal(double value)
    {
      if (!CheckBalance(value))
      {
        Console.WriteLine("This ammount is higher than you have in your account.\n" +
        $"Your current balance is US${Balance}");
        return;
      }

      this.Balance -= value;
      Console.WriteLine($"Deposit completed.\nYou have US${Balance} in your account.");
    }

    public override void Transfer(double ammount, BankAccount destinyAccount)
    {
      if (!CheckBalance(ammount))
        Console.WriteLine("You don't have enough money to transfer!");

      destinyAccount.Deposit(ammount);
      Console.WriteLine("Deposit done.");
    }

    private bool CheckBalance(double ammount)
    {
      return Balance >= ammount;
    }

    public void PrintBalance()
    {
      Console.WriteLine($"{Client.Name} have US${Balance} in account {Id}");
    }
  }
}