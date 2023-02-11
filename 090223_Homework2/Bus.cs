namespace _090223_Homework2
{
  class Bus : Vehicle
  {
    public double FuelConsumption { get; set; }
    public Bus(double fuelQuantity, double litersPerKm, double tankCapacity)
      : base(fuelQuantity, litersPerKm + 1.4, tankCapacity)
    { }

    public override void Drive(double distance)
    {
      double neededFuel = distance * this.FuelConsumption;
      if (neededFuel <= this.FuelQuantity)
      {
        this.FuelQuantity -= neededFuel;
        Console.WriteLine($"Bus travelled {distance} km");
      }
      else
      {
        Console.WriteLine("Bus needs refueling");
      }
    }

    public void DriveEmpty(double distance)
    {
      double fuelNeeded = distance * (FuelConsumption - 1.4);
      if (fuelNeeded <= FuelQuantity)
      {
        FuelQuantity -= fuelNeeded;
        Console.WriteLine("Bus travelled {0} km", distance);
      }
      else
      {
        Console.WriteLine("Bus needs refueling");
      }
    } 
    
    public void DriveWithPeople(double distance)
    {
      if (distance * (FuelConsumption + 1.4) <= FuelQuantity)
      {
        FuelQuantity -= distance * (FuelConsumption + 1.4);
        Console.WriteLine($"Bus travelled {distance} km");
      }
      else
      {
        Console.WriteLine("Bus needs refueling");
      }
    }
  }

}