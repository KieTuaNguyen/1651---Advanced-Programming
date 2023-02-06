namespace _060223_Homework2
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();
      System.Console.WriteLine("Enter your age: ");
      int age = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Enter your ID: ");
      string id = Console.ReadLine();
      System.Console.WriteLine("Enter your date of birth: ");
      string birthdate = Console.ReadLine();
      IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
      IBirthable birthable = new Citizen(name, age, id, birthdate);
      Console.WriteLine("---");
      Console.WriteLine(identifiable.Id);
      Console.WriteLine(birthable.Birthdate);
    }
  }
}