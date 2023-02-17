namespace _160223_Classwork1
{
  public interface IChoice
  {
    void MyChoice();
  }

  public class FirstChoice : IChoice
  {
    public void MyChoice()
    {
      Console.WriteLine("Traveling to Japan");
    }
  }
  public class SecondChoice : IChoice
  {
    public void MyChoice()
    {
      Console.WriteLine("Traveling to India");
    }
  }

  public class Context
  {
    IChoice choice;
    public void SetChoice(IChoice choice)
    {
      this.choice = choice;
    }
    public void ShowChoice()
    {
      choice.MyChoice();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***Strategy Pattern Demo***\n");
      IChoice ic = null;
      Context cxt = new Context();
      for (int i = 1; i <= 2; i++)
      {
        Console.WriteLine("\nEnter your choice(1 or 2)");
        string c = Console.ReadLine();
        if (c.Equals("1"))
        {
          ic = new FirstChoice();
        }
        else
        {
          ic = new SecondChoice();
        }
        cxt.SetChoice(ic);
        cxt.ShowChoice();

      }
    }
  }
}
