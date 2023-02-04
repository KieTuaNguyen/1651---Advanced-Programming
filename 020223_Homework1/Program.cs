namespace _020223_Homework1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Enter name: ");
      string name = Console.ReadLine();
      System.Console.WriteLine("Enter age: ");
      int age = int.Parse(Console.ReadLine());

      // System.Console.WriteLine("---");
      // Person person = new Person(name, age);
      // System.Console.WriteLine(person);

      System.Console.WriteLine("---");
      Child child = new Child(name, age);
      System.Console.WriteLine(child);

    }
  }
}