using services;

namespace Views
{
  public interface IView
  {
    string ShowView(BankAccountService bankAccountService);
  }
}