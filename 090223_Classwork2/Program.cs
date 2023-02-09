namespace _090223_Classwork2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Animal cat = new Cat("Pesho", "Whiskas");
      Animal dog = new Dog("Gosho", "Meat");

      Console.WriteLine(cat.ExplainSelf());
      Console.WriteLine(dog.ExplainSelf());
    }
  }
}