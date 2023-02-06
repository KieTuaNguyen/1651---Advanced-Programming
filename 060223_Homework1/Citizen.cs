namespace _060223_Homework1
{
  internal class Citizen : IPerson
  {
    //Auto implemented properties
    public string Name { get; set; }
    public int Age { get; set; }

    //Constructors
    public Citizen()
    {

    }
    public Citizen(string name, int age)
    {
      Name = name;
      Age = age;
    }

    //To String method
    public override string ToString()
    {
      return $"{this.Name} are {this.Age} years old.";
    }
  }
}