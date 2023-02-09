namespace _090223_Classwork2
{
  internal class Dog : Animal
  {
    //Constructors
    public Dog()
    {
    }
    public Dog(string name, string favoriteFood) : base(name, favoriteFood)
    {
    }

    //Methods
    public override string ExplainSelf()
    {
      return base.ExplainSelf() + "\nDJAAF";
    }
  }
}