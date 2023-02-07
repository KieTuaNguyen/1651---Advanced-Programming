namespace _060223_Homework3
{
  internal class StationaryPhone : IPhone
  {
    public void Call(string number)
    {
      Console.WriteLine("Dialing... " + number);
    }
  }
}