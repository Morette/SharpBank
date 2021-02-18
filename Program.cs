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
      BankAccountRepository bankAccountRepository = new BankAccountRepository();
      BankAccountService bankAccountService = new BankAccountService(bankAccountRepository);

      string clientOption = new MainView().ShowView(bankAccountService);
      Start(clientOption, bankAccountService);
    }

    static void Start(string clientOption, BankAccountService bankAccountService)
    {
      switch (clientOption)
      {
        case "1":
          Console.WriteLine(new CreateAccountView().ShowView(bankAccountService));
          break;
        case "2":
          bankAccountService.ListAllAccount().ForEach(account =>
          {
            Console.WriteLine($"ID: {account.Id} | type: {account.AccountType} | client: {account.Client.Name} | balance: {account.Balance}");
          });
          break;
        case "3":
          Console.WriteLine(new TransferView().ShowView(bankAccountService));
          break;
        case "4":
          Console.WriteLine(new WithdrawalView().ShowView(bankAccountService));
          break;
        case "5":
          Console.WriteLine(new DepositView().ShowView(bankAccountService));
          break;
        default:
          Console.WriteLine("Please choose a valid option");
          break;
      }

      if (clientOption.ToUpper() == "X")
      {
        Environment.Exit(0);
      }

      clientOption = new MainView().ShowView(bankAccountService);
      Start(clientOption, bankAccountService);
    }
  }
}
