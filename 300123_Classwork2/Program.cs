namespace _300123_Classwork2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("Enter the number of person: ");
      var lines = int.Parse(Console.ReadLine());
      var people = new List<Person>();
      System.Console.WriteLine("---Input---");
      for (int i = 0; i < lines; i++)
      {
        System.Console.Write($"Enter the name of {i + 1} person: ");
        var name = Console.ReadLine();
        System.Console.Write($"Enter the age of {i + 1} person: ");
        var age = int.Parse(Console.ReadLine());
        System.Console.Write($"Enter the salary of {i + 1} person: ");
        var salary = decimal.Parse(Console.ReadLine());
        Person person = new Person(name, age, salary);
        people.Add(person);
        System.Console.WriteLine("---");
      }
      System.Console.WriteLine("---Output---");
      foreach (var person in people)
      {
        System.Console.WriteLine(person);
        System.Console.WriteLine("------");
      }
      System.Console.WriteLine("---Sorted by name---");
      var sorted = people.OrderBy(p => p.Name).ThenBy(p => p.Age).ToList();
      Console.WriteLine(string.Join(Environment.NewLine, sorted));
    }
  }
}