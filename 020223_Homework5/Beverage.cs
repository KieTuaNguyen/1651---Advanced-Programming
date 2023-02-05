namespace _020223_Homework5
{
  internal class Beverage : Product
  {
    //Fields
    private double milliliters;

    //Properties
    public double Milliliters
    {
      get { return milliliters; }
      set { milliliters = value; }
    }

    //Constructors
    public Beverage()
    {

    }
    public Beverage(string name, decimal price, double milliliters) : base(name, price)
    {
      Milliliters = milliliters;
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Milliliters: {Milliliters}";
    }
  }
}