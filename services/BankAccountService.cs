using System;
using System.Collections.Generic;
using Account.Enums;
using models;
using Repository;

namespace services
{
  public class BankAccountService : IAccountService<BankAccount>
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

    public bool Deposit(string bankId, string value)
    {
      int account = 0;
      double ammount = 0;

      if (!int.TryParse(bankId, out account))
      {
        Console.WriteLine("Please, input a valid account number");
        return false;
      }

      if (!double.TryParse(value, out ammount))
      {
        Console.WriteLine("Please, input a valid ammount");
        return false;
      }

      _bankAccountRepository.Deposit(account, ammount);
      return true;
    }

    public bool Withdrawal(string bankId, string value)
    {
      int account = 0;
      double ammount = 0;

      if (!int.TryParse(bankId, out account))
      {
        Console.WriteLine("Please, input a valid account number");
        return false;
      }

      if (!double.TryParse(value, out ammount))
      {
        Console.WriteLine("Please, input a valid ammount");
        return false;
      }

      if (!CheckBalance(account, ammount))
      {
        double? balance = _bankAccountRepository.CheckBalance(account);
        Console.WriteLine("Please verify if the ammount and account are correct.");
        return false;
      }

      return _bankAccountRepository.Withdrawal(account, ammount);
    }

    public bool Transfer(string originalAccount, string destinyAccount, string value)
    {
      int initialAccount = 0;
      int finalAccount = 0;
      double ammount = 0;

      if (!int.TryParse(destinyAccount, out finalAccount) || !int.TryParse(originalAccount, out initialAccount))
      {
        Console.WriteLine("Please, input a valid account number");
        return false;
      }

      if (!double.TryParse(value, out ammount))
      {
        Console.WriteLine("Please, input a valid ammount");
        return false;
      }

      if (!CheckBalance(initialAccount, ammount))
      {
        Console.WriteLine("You don't have enough money to transfer or the account does not exist.");
        return false;
      }

      if (!_bankAccountRepository.Withdrawal(initialAccount, ammount))
      {
        Console.WriteLine("Please verify if the destination account is correct.");
        return false;
      }

      _bankAccountRepository.Deposit(finalAccount, ammount);
      return true;
    }

    private bool CheckBalance(int account, double value)
    {
      double? balance = _bankAccountRepository.CheckBalance(account);
      return balance is not null ? balance > value : false;
    }
  }
}