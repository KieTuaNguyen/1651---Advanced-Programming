namespace _090223_Homework2
{
  public class Car : Vehicle
  {
    public Car(double fuelQuantity, double litersPerKm, double tankCapacity)
        : base(fuelQuantity, litersPerKm + 0.9, tankCapacity)
    {
    }
  }
}