namespace Classwork4
{
  internal class Program
  {
    class PriceCalculator
    {
      public enum Season
      {
        Autumn = 1,
        Spring = 2,
        Summer = 3,
        Winter = 4
      }

      public enum Discount
      {
        None = 0,
        SecondVisit = 10,
        Vip = 20
      }

      public static double CalculateTotalPrice(double pricePerDay, int numberOfDays, Season season, Discount discount)
      {
        double seasonMultiplier = (double)season;
        double totalPrice = pricePerDay * numberOfDays * seasonMultiplier;
        double discountType = (double)discount / 100;
        return totalPrice - (totalPrice * discountType);
      }

    }
    static void Main(string[] args)
    {
      double pricePerDay = 100;
      int numberOfDays = 7;
      PriceCalculator.Season season = PriceCalculator.Season.Summer;
      PriceCalculator.Discount discount = PriceCalculator.Discount.Vip;

      double totalPrice = PriceCalculator.CalculateTotalPrice(pricePerDay, numberOfDays, season, discount);
      Console.WriteLine("--------------------");
      Console.WriteLine("Total Price: " + totalPrice);
      Console.WriteLine("--------------------");
    }
  }
}