namespace _060223_Classwork1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("---Cat section");
      Cat cat = new Cat("Tom");
      cat.Eat();
      cat.Run();
      cat.Climb();
      Console.WriteLine("--------------");
      Console.WriteLine("---Cow section");
      Cow cow = new Cow("Tri Minh");
      cow.Run();
      cow.Eat();
      cow.Sleep();
    }
  }
}