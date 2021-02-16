using System;
using System.Collections.Generic;
using Account.Enums;
using models;
using Repository;

namespace services
{
  public class BankAccountService : IAccountService
  {
    private BankAccountRepository _bankAccountRepository;

    public BankAccountService(BankAccountRepository bankAccountRepository)
    {
      this._bankAccountRepository = bankAccountRepository;
    }

    public List<BankAccount> ListAllAccount()
    {
      return _bankAccountRepository.ListAllAccount();
    }

    public void Create(string accountType, string clientName, string balance)
    {
      Client client = new Client(clientName);
      int account = 0;
      double value = 0;

      int.TryParse(accountType, out account);
      double.TryParse(balance, out value);

      switch (account)
      {
        case (int)AccountType.NORMAL_PERSON:
          _bankAccountRepository.Create(AccountType.NORMAL_PERSON, client, value);
          break;
        case (int)AccountType.LEGAL_PERSON:
          _bankAccountRepository.Create(AccountType.LEGAL_PERSON, client, value);
          break;
      }
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