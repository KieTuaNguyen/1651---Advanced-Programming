namespace _020223_Homework4
{
  internal class Vehicle
  {
    //Field
    int horsePower;
    double fuel;

    //Properties
    public int HorsePower { get => horsePower; set => horsePower = value; }
    public double Fuel { get => fuel; set => fuel = value; }
    public static double DefaultFuelConsumption = 1.25;
    public virtual double FuelConsumption { get; set; } = DefaultFuelConsumption;

    //Methods
    public virtual void Drive(double kilometers)
    {
      double fuelNeeded = kilometers * FuelConsumption;
      if (fuelNeeded <= Fuel)
      {
        Fuel -= fuelNeeded;
        Console.WriteLine($"{this.GetType().Name} is driven {kilometers} kilometers.");
      }
      else
      {
        Console.WriteLine($"{this.GetType().Name} does not have enough fuel to drive.");
      }
    }

    //Constructor
    public Vehicle()
    {

    }

    public Vehicle(int horsePower, double fuel)
    {
      HorsePower = horsePower;
      Fuel = fuel;
    }

    public override string ToString()
    {
      return $"Type: {this.GetType().Name} - Horse Power: {this.HorsePower} - Fuel: {this.Fuel}";
    }
  }
}