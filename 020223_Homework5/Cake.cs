namespace _020223_Homework5
{
  internal class Cake : Dessert
  {
    public new static double Grams = 250;
    public new static double Calories = 1000;
    public static double CakePrice = 5;

    public Cake(string name) : base(name, (decimal)CakePrice, Grams, Calories)
    {
    }
    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price:f2} - Grams: {Grams} - Calories: {Calories}";
    }
  }
}