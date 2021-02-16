using System;

namespace Views
{
  public abstract class AbstractView : IView
  {
    public string ShowView()
    {
      Console.WriteLine("Sharpbank at your service");
      Console.WriteLine("Choose your destiny:\n");
      Console.WriteLine("1. List accounts");
      Console.WriteLine("2. Create new account");
      Console.WriteLine("3. Transfer");
      Console.WriteLine("4. Withdrawal");
      Console.WriteLine("5. Deposit");
      Console.WriteLine("X - Exit\n");

      return Console.ReadLine();
    }
  }
}