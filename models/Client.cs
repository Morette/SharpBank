using System;

namespace models
{
  public class Client
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public Client(string name)
    {
      this.Name = name;
      this.Id = new Random().Next(1, 1000);
    }
  }
}