namespace _060223_Homework6
{
  internal class Citizen : IBuyer
  {
    //Auto implemented properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }
    public string Birthday { get; set; }

    //Constructors
    public Citizen()
    {
    }
    public Citizen(string name, int age, string id, string birthday)
    {
      Name = name;
      Age = age;
      ID = id;
      Birthday = birthday;
    }

    //Implementation of BuyFood method from IBuyer interface
    public int Food { get; set; }

    public void BuyFood()
    {
      Food += 10;
    }
  }

}