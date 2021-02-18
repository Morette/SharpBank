namespace Views
{
  public interface IView<T>
  {
    string ShowView(T t);
  }
}