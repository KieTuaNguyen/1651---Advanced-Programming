namespace _090223_Homework2
{
  public abstract class Vehicle
  {
    private double fuelQuantity;
    private double litersPerKm;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
    {
      this.FuelQuantity = fuelQuantity;
      this.LitersPerKm = litersPerKm;
      this.TankCapacity = tankCapacity;
    }

    public double FuelQuantity
    {
      get { return fuelQuantity; }
      set
      {
        if (value > this.tankCapacity)
        {
          this.fuelQuantity = 0;
        }
        else
        {
          this.fuelQuantity = value;
        }
      }
    }

    public double LitersPerKm
    {
      get { return litersPerKm; }
      set { litersPerKm = value; }
    }

    public double TankCapacity
    {
      get { return tankCapacity; }
      set { tankCapacity = value; }
    }

    public object FuelConsumption { get; set; }

    public virtual void Drive(double distance)
    {
      double neededFuel = distance * this.LitersPerKm;

      if (neededFuel <= this.FuelQuantity)
      {
        this.FuelQuantity -= neededFuel;
        Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
      }
      else
      {
        Console.WriteLine($"{this.GetType().Name} needs refueling");
      }
    }

    public virtual void Refuel(double liters)
    {
      if (liters <= 0)
      {
        Console.WriteLine("Fuel must be a positive number");
      }
      else if (this.FuelQuantity + liters > this.TankCapacity)
      {
        Console.WriteLine($"Cannot fit {liters} fuel in the tank");
      }
      else
      {
        this.FuelQuantity += liters;
      }
    }
  }
}