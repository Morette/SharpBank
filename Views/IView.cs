namespace Views
{
  public interface IView
  {
    UserOption ShowView();
  }

  public class UserOption
  {
    public string Option { get; set; }
    public string[] UserOptions;

    public UserOption(string option, string[] userOptions)
    {
      this.Option = option;
      this.UserOptions = userOptions;
    }
  }
}