namespace _020223_Homework5
{
  internal class Dessert : Food
  {
    //Fields
    private double calories;

    //Properties
    public double Calories
    {
      get { return calories; }
      set { calories = value; }
    }

    //Constructors
    public Dessert()
    {
    }

    public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
    {
      Calories = calories;
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Grams: {Grams} - Calories: {Calories}";
    }
  }
}