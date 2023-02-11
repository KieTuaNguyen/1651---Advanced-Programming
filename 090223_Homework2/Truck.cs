namespace _090223_Homework2
{
  public class Truck : Vehicle
  {
    public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
        : base(fuelQuantity, litersPerKm + 1.6, tankCapacity)
    {
    }

    public override void Refuel(double liters)
    {
      base.Refuel(liters * 0.95);
    }
  }

}