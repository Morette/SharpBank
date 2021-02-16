using System;
using services;

namespace Views
{
  public class MainView : AbstractView
  {
    public override string ShowView(BankAccountService bankAccountService)
    {
      string[] options = new string[] { "1", "2", "3", "4", "5", "X" };

      Console.WriteLine("\nNetBank at your service");
      Console.WriteLine("Choose your destiny:\n");
      Console.WriteLine("1. Create new account");
      Console.WriteLine("2. List accounts");
      Console.WriteLine("3. Transfer");
      Console.WriteLine("4. Withdrawal");
      Console.WriteLine("5. Deposit");
      Console.WriteLine("X. Exit\n");

      return Console.ReadLine();
    }
  }
}