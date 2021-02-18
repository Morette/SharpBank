using System.Collections.Generic;
using Account.Enums;

namespace Repository
{
  public interface IAccountRepository<T, E>
  {
    public List<T> ListAllAccount();
    public void Create(AccountType accountType, E e, double balance);
    public bool Deposit(int bank, double ammount);
    public bool Withdrawal(int bank, double ammount);
  }
}