namespace _060223_Homework2
{
  internal class Citizen : IPerson, IIdentifiable, IBirthable
  {
    //Auto implemented properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }

    //Constructors
    public Citizen()
    {

    }
    public Citizen(string name, int age, string id, string birthdate)
    {
      Name = name;
      Age = age;
      Id = id;
      Birthdate = birthdate;
    }
  }
}