namespace _020223_Homework5
{
  internal class Food : Product
  {
    //Fields
    private double grams;

    //Properties
    public double Grams
    {
      get { return grams; }
      set { grams = value; }
    }

    //Constructors
    public Food()
    {
    }

    public Food(string name, decimal price, double grams) : base(name, price)
    {
      Grams = grams;
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
    }
  }
}