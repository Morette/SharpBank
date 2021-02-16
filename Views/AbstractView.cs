using services;

namespace Views
{
  public abstract class AbstractView : IView
  {
    public abstract string ShowView(BankAccountService bankAccountService);
  }
}