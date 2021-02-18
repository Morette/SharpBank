using System;
using services;

namespace Views
{
  public class WithdrawalView : AbstractView<BankAccountService>
  {
    public override string ShowView(BankAccountService bankAccountService)
    {
      Console.WriteLine("Please inform your account. Or press 0 to return.");
      string account = Console.ReadLine();

      if (account == "0")
        return string.Empty;

      Console.WriteLine("Please inform the value to withdraw.");
      string ammount = Console.ReadLine();

      return bankAccountService.Withdrawal(account, ammount) ? "Withdraw completed." : "Withdraw not available.";
    }
  }
}