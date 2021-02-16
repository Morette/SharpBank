using System;
using Account.Enums;
using models;
using Repository;

namespace services
{
  public class BankAccountService : IAccount
  {
    private BankAccountRepository _bankAccountRepository;

    public BankAccountService(BankAccountRepository bankAccountRepository)
    {
      this._bankAccountRepository = bankAccountRepository;
    }

    public void Create(AccountType accountType, Client client, double balance = 0)
    {
      _bankAccountRepository.Create(accountType, client, balance);
    }

    public void Deposit(BankAccount bank, double value)
    {
      _bankAccountRepository.Deposit(bank, value);
    }

    public void Withdrawal(BankAccount bank, double value)
    {
      if (CheckBalance(bank, value))
      {
        double balance = _bankAccountRepository.CheckBalance(bank);
        Console.WriteLine("This ammount is higher than you have in your account.\n" +
          $"Your current balance is US${balance}");
        return;
      }

      _bankAccountRepository.Withdrawal(bank, value);
      Console.WriteLine($"Deposit completed.");
    }

    public void Transfer(BankAccount destinyAccount, double value)
    {
      if (!CheckBalance(destinyAccount, value))
        Console.WriteLine("You don't have enough money to transfer!");

      _bankAccountRepository.Deposit(destinyAccount, value);
      Console.WriteLine("Deposit done.");
    }

    private bool CheckBalance(BankAccount bank, double value)
    {
      double balance = _bankAccountRepository.CheckBalance(bank);
      return balance < value;
    }
  }
}