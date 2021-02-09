namespace models
{
   public class Client
   {
      public string Name { get; set; }

      public Client(string name)
      {
         this.Name = name;
      }
   }
}