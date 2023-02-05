namespace _020223_Homework6
{
  internal class Cat : Animal
  {
    //Constructors
    public Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
      return "Meow meow";
    }
  }
}