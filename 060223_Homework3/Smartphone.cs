namespace _060223_Homework3
{
  internal class Smartphone : IPhone
  {
    public void Call(string number)
    {
      Console.WriteLine("Calling... " + number);
    }
  }
}