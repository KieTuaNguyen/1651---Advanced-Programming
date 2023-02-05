namespace _020223_Homework6
{
  internal class Kitten : Cat
  {
    //Constructors
    public Kitten(string name, int age) : base(name, age, "Female")
    {
    }

    public override string ProduceSound()
    {
      return "Meow!";
    }
  }
}