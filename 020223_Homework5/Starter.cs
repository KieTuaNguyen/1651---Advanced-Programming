namespace _020223_Homework5
{
  internal class Starter : Food
  {
    //Constructors
    public Starter()
    {
    }

    public Starter(string name, decimal price, double grams) : base(name, price, grams)
    {
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price} - Grams: {Grams}";
    }
  }
}