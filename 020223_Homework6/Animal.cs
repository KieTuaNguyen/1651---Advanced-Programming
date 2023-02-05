namespace _020223_Homework6
{
  internal class Animal
  {
    //Fields
    string name;
    int age;
    string gender;

    //Properties
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public int Age
    {
      get { return age; }
      set { age = value; }
    }
    public string Gender
    {
      get { return gender; }
      set { gender = value; }
    }

    //Constructors
    public Animal()
    {
    }
    public Animal(string name, int age, string gender)
    {
      Name = name;
      Age = age;
      Gender = gender;
    }

    public virtual string ProduceSound() => "Animal sounds";

    public override string ToString() =>
    $"{GetType().Name}" +
    $"\n{Name} {Age} {Gender}" +
    $"\n{ProduceSound()}";
  }
}