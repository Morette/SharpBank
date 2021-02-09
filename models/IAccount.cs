namespace models
{
   public interface IAccount
   {
      public void Deposit(double value);
      public void Withdrawal(double value);
   }
}