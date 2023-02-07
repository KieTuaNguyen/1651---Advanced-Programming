namespace _060223_Homework5
{
  internal class Citizen
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
    public Citizen(string s, string name, int age, string id, string birthday)
    {
      Name = name;
      Age = age;
      ID = id;
      Birthday = birthday;
    }
  }

}