using System;
using models.enums;

namespace models
{
   public class Account : IAccount
   {
      private AccountType AccountType { get; set; }
      private Client Client { get; set; }
      private double Balance { get; set; }

      public Account(AccountType accountType, Client client)
      {
         this.Client = client;
         this.AccountType = accountType;
         this.Balance = 0;
      }

      public Account(AccountType accountType, Client client, double balance)
      {
         this.AccountType = accountType;
         this.Client = client;
         this.Balance = balance;
      }

      public void Deposit(double value)
      {
         this.Balance += value;
         Console.WriteLine($"US${value} deposited.\n" +
         $"{this.Client.Name} actual balance is US${this.Balance}");
      }

      public void Withdrawal(double value)
      {
         if (!CheckBalance(value))
         {
            Console.WriteLine("This ammount is higher than you have in your account.\n" +
            $"Your current balance is US${this.Balance}");
            return;
         }

         this.Balance -= value;
         Console.WriteLine($"Deposit completed.\nYou have US${this.Balance} in your account.");
      }

      public void Transfer(double ammount, Account destinyAccount)
      {
         if (!CheckBalance(ammount))
            Console.WriteLine("You don't have enough money to transfer!");

         destinyAccount.Deposit(ammount);
         Console.WriteLine("Deposit done.");
      }

      private bool CheckBalance(double ammount)
      {
         return this.Balance >= ammount;
      }

      public void PrintBalance()
      {
         Console.WriteLine($"{this.Client.Name} have US${this.Balance} in account.");
      }
   }
}