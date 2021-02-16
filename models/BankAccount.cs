using Account.Enums;

namespace models
{
  public class BankAccount : AbstractBankAccount
  {
    public BankAccount(AccountType accountType, Client client) : base(accountType, client) { }

    public BankAccount(AccountType accountType, Client client, double balance) : base(accountType, client, balance) { }
  }
}