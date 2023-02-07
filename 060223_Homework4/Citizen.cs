namespace _060223_Homework4
{
  internal class Citizen
  {
    //Auto implemented properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }

    //Constructors
    public Citizen()
    {

    }
    public Citizen(string name, int age, string id)
    {
      Name = name;
      Age = age;
      ID = id;
    }
  }

}