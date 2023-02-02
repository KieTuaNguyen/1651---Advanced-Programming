namespace CustomRandomList
{
  public class RandomList : List<string>
  {
    private Random random;

    public string RandomString()
    {
      int index = random.Next(0, this.Count);
      string element = this[index];
      this.RemoveAt(index);
      return element;
    }
  }
}