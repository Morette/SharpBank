using System;
using Views;

namespace bank
{
  class Program
  {
    static void Main(string[] args)
    {
      int option = 0;

      MainView mainView = new MainView();
      string clientOption = mainView.ShowView();

      while (!int.TryParse(clientOption, out option) || !(clientOption.ToUpper() == "X"))
      {
        Console.WriteLine("Please choose a valid option");
        mainView.ShowView();
      }

      if (clientOption.ToUpper() == "X")
        Environment.Exit(0);

    }
  }
}
