namespace _020223_Homework5
{
  internal class Tea : HotBeverage
  {
    //Constructors
    public Tea()
    {
    }

    public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters}";
    }
  }
}