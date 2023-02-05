namespace _020223_Homework6
{
  internal class Dog : Animal
  {
    //Constructors
    public Dog(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
      return "Woof!";
    }
  }
}