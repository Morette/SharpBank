namespace Views
{
  public abstract class AbstractView<T> : IView<T>
  {
    public abstract string ShowView(T t);
  }
}