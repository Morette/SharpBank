using System;
using Account.Enums;
using services;

namespace Views
{
  public class CreateAccountView : AbstractView<BankAccountService>
  {
    public override string ShowView(BankAccountService bankAccountService)
    {
      Console.WriteLine("\nPlease choose your account type:");

      foreach (int item in Enum.GetValues(typeof(AccountType)))
      {
        Console.WriteLine($"{item}. {Enum.GetName(typeof(AccountType), item)}");
      }

      string accountType = Console.ReadLine();

      Console.WriteLine("Informe your name:");
      string clientName = Console.ReadLine();

      Console.WriteLine("Please, input your initial balance:");
      string balance = Console.ReadLine();

      bankAccountService.Create(accountType, clientName, balance);
      return "Account created";
    }
  }
}