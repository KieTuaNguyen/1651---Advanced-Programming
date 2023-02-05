namespace _020223_Homework5
{
  internal class Fish : MainDish
  {
    //Fields
    public new static double Grams;
    //Constructors
    public Fish(string name, decimal price) : base(name, price, Grams)
    {
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
    }
  }
}