namespace _090223_Classwork2
{
  internal class Cat : Animal
  {
    //Constructors
    public Cat()
    {
    }
    public Cat(string name, string favoriteFood) : base(name, favoriteFood)
    {
    }

    //Methods
    public override string ExplainSelf()
    {
      return base.ExplainSelf() + "\nMEEOW";
    }
  }
}