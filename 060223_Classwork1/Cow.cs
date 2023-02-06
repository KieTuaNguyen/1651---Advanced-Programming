namespace _060223_Classwork1
{
  internal class Cow : Animal, ICanRun
  {
    public override void Sleep()
    {
      System.Console.WriteLine($"{this.Name} is sleeping.");
    }

    public override void Eat()
    {
      System.Console.WriteLine($"{this.Name} is eating grass.");
    }

    public void Run()
    {
      System.Console.WriteLine($"{this.Name} is running slowly.");
    }

    //Constructor
    public Cow(string name) : base(name)
    {
    }
  }
}