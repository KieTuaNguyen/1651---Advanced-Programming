namespace _060223_Homework6
{
  internal class Rebel : IBuyer
  {
    //Auto implemented properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }

    //Constructors
    public Rebel()
    {
    }
    public Rebel(string name, int age, string group)
    {
      Name = name;
      Age = age;
      Group = group;
    }

    //Implementation of BuyFood method from IBuyer interface
    public int Food { get; set; }

    public void BuyFood()
    {
      Food += 5;
    }
  }
}