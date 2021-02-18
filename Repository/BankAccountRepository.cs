using System.Collections.Generic;
using System.Linq;
using Account.Enums;
using models;

namespace Repository
{
  public class BankAccountRepository : IAccountRepository<BankAccount, Client>
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

    public bool Deposit(int bankId, double ammount)
    {
      BankAccount bank = VerifyIfAccountExist(bankId);

      if (bank is null)
        return false;

      bank.Balance += ammount;
      return true;
    }

    public bool Withdrawal(int bankId, double ammount)
    {
      BankAccount bank = VerifyIfAccountExist(bankId);

      if (bank is null)
        return false;

      bank.Balance -= ammount;
      return true;
    }

    public double? CheckBalance(int bankId)
    {
      BankAccount bank = VerifyIfAccountExist(bankId);
      return bank is null ? null : bank.Balance;
    }

    public BankAccount VerifyIfAccountExist(int bankId)
    {
      return ListAllAccount().FirstOrDefault(account => account.Id == bankId);
    }
  }
}