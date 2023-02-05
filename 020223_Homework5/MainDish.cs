namespace _020223_Homework5
{
  internal class MainDish : Food
  {
    //Constructors
    public MainDish()
    {
    }

    public MainDish(string name, decimal price, double grams) : base(name, price, grams)
    {
      Grams = grams;
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
    }
  }
}