namespace _020223_Homework6
{
  internal class TomCat : Cat
  {
    //Constructors
    public TomCat(string name, int age) : base(name, age, "Male")
    {
    }

    public override string ProduceSound()
    {
      return "MEOW!";
    }
  }
}