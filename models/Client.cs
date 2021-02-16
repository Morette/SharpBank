namespace models
{
  public class Client
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public Client(string name)
    {
      this.Name = name;
    }
  }
}