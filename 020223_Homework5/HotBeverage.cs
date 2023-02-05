namespace _020223_Homework5
{
  internal class HotBeverage : Beverage
  {
    //Constructors
    public HotBeverage()
    {

    }
    public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters}";
    }
  }
}