using System;
using services;

namespace Views
{
  public class DepositView : AbstractView<BankAccountService>
  {
    public override string ShowView(BankAccountService bankAccountService)
    {
      Console.WriteLine("Please inform your account or type 0 to return.");
      string account = Console.ReadLine();

      if (account == "0")
        return string.Empty;

      Console.WriteLine("Please inform the value to deposit.");
      string ammount = Console.ReadLine();

      return bankAccountService.Deposit(account, ammount) ? "Deposit completed." : "Deposit not available.";
    }
  }
}