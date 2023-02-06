namespace _060223_Classwork1
{
  internal class Cat : Animal, ICanRun, ICanClimbJump
  {
    public override void Sleep()
    {
      System.Console.WriteLine($"{this.Name} is sleeping.");
    }

    public override void Eat()
    {
      System.Console.WriteLine($"{this.Name} is eating rice, fish and meat.");
    }
    public void Run()
    {
      System.Console.WriteLine($"{this.Name} is running fast.");
    }
    public void Climb()
    {
      System.Console.WriteLine($"{this.Name} is climbing a tree.");
    }

    public void Jump()
    {
    }

    //Constructor
    public Cat(string name) : base(name)
    {
    }
  }
}