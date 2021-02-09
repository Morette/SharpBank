using System;
using models;
using models.enums;

namespace bank
{
   class Program
   {
      static void Main(string[] args)
      {
         Client thiago = new Client("thiago morette");
         Client kamila = new Client("kamila araujo");
         Account thiagoAccount = new Account(AccountType.NORMAL_PERSON, thiago, 500);
         Account kamilaAccount = new Account(AccountType.NORMAL_PERSON, kamila, 500);

         thiagoAccount.Deposit(200);
         thiagoAccount.Withdrawal(850);

         thiagoAccount.Transfer(200, kamilaAccount);
         kamilaAccount.PrintBalance();
      }
   }
}
