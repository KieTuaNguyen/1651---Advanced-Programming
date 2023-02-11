namespace _090223_Homework1
{
  class Truck : Vehicle
  {
    public Truck(double fuelQuantity, double litersPerKm)
        : base(fuelQuantity, litersPerKm + 1.6)
    {
    }

    public override void Refuel(double liters)
    {
      base.Refuel(liters * 0.95);
    }
  }
}