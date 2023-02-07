namespace _060223_Homework5
{
  internal class Pet
  {
    //Auto implemented properties
    public string Name { get; set; }
    public string Birthday { get; set; }

    //Constructors
    public Pet()
    {
    }
    public Pet(string s, string name, string birthday)
    {
      Name = name;
      Birthday = birthday;
    }
  }
}