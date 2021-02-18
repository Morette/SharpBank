using System;
using services;

namespace Views
{
  public class TransferView : AbstractView<BankAccountService>
  {
    public override string ShowView(BankAccountService bankAccountService)
    {
      bankAccountService.ListAllAccount().ForEach(account =>
      {
        Console.WriteLine($"ID: {account.Id} | type: {account.AccountType} | client: {account.Client.Name} | balance: {account.Balance}");
      });

      Console.WriteLine("Inform the number of your account or type 0 to return.");
      string account = Console.ReadLine();

      if (account == "0")
        return string.Empty;

      Console.WriteLine("Inform the number of the account you want to transfer to.");
      string destinationAccount = Console.ReadLine();

      Console.WriteLine("Inform the value to transfer");
      string value = Console.ReadLine();

      return bankAccountService.Transfer(account, destinationAccount, value) ? "Transfer completed" : "Transfer failed";
    }
  }
}