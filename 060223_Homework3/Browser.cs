namespace _060223_Homework3
{
  internal class Browser : IBrowser
  {
    public void Browse(string site)
    {
      Console.WriteLine("Browsing: " + site + "!");
    }
  }
}