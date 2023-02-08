namespace _060223_Homework6
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());

      List<IBuyer> buyers = new List<IBuyer>();

      for (int i = 0; i < n; i++)
      {
        string[] tokens = Console.ReadLine().Split();

        if (tokens.Length == 4)
        {
          buyers.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
        }
        else if (tokens.Length == 3)
        {
          buyers.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
        }
      }

      string name;
      while ((name = Console.ReadLine()) != "End")
      {
        IBuyer buyer = buyers.Find(b => b.Name == name);
        if (buyer != null)
        {
          buyer.BuyFood();
        }
      }

      Console.WriteLine(buyers.Sum(b => b.Food));
    }
  }
}