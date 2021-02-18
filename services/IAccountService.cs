using System.Collections.Generic;

namespace services
{
  public interface IAccountService<T>
  {
    public List<T> ListAllAccount();
    public void Create(string accountType, string clientName, string balance);
    public bool Deposit(string bankId, string ammount);
    public bool Withdrawal(string bankId, string ammount);
    public bool Transfer(string account, string destinationAccount, string ammount);
  }
}