namespace _020223_Homework6
{
  internal class Frog : Animal
  {
    //Constructors
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
      return "Ribbit!";
    }
  }
}