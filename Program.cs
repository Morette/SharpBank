using System;
using Repository;
using services;
using Views;

namespace bank
{
  class Program
  {
    static void Main()
    {
      Start();
    }

    static void Start()
    {
      BankAccountRepository bankAccountRepository = new BankAccountRepository();
      BankAccountService bankAccountService = new BankAccountService(bankAccountRepository);

      string clientOption = new MainView().ShowView(bankAccountService);

      switch (clientOption)
      {
        case "1":
          Console.WriteLine(new CreateAccountView().ShowView(bankAccountService));
          break;
        case "2":
          break;
        default:
          Console.WriteLine("Please choose a valid option");
          break;
      }

      if (clientOption.ToUpper() == "X")
      {
        Environment.Exit(0);
      }

      Start();
    }
  }
}
