using System;
using System.Linq;
using Views;

namespace bank
{
  class Program
  {
    static void Main()
    {
      int option = 0;

      MainView mainView = new MainView();
      UserOption clientOption = mainView.ShowView();

      while (!clientOption.UserOptions.Any(item => item == clientOption.Option.ToUpper()))
      {
        Console.WriteLine("Please choose a valid option.");
        clientOption = mainView.ShowView();
      }

      if (int.TryParse(clientOption.Option, out option))
        Start(option);

      Environment.Exit(0);
    }

    private static void Start(int clientOption)
    {
      switch (clientOption)
      {
        case 1:
          new MainView().ShowView();
          break;
        default:
          return;
      }
    }
  }
}
