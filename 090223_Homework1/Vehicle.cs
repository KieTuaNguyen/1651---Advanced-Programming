namespace _090223_Homework1
{
  class Vehicle
  {
    public double FuelQuantity { get; set; }
    public double LitersPerKm { get; set; }

    public Vehicle(double fuelQuantity, double litersPerKm)
    {
      FuelQuantity = fuelQuantity;
      LitersPerKm = litersPerKm;
    }

    public virtual void Drive(double distance)
    {
      double neededFuel = distance * LitersPerKm;

      if (FuelQuantity >= neededFuel)
      {
        FuelQuantity -= neededFuel;
        Console.WriteLine("Vehicle travelled {0} km", distance);
      }
      else
      {
        Console.WriteLine("Vehicle needs refueling");
      }
    }

    public virtual void Refuel(double liters)
    {
      FuelQuantity += liters;
    }
  }
}