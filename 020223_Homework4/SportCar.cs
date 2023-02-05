namespace _020223_Homework4
{
  internal class SportCar : Car
  {
    public new static double DefaultFuelConsumption = 10;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;
    public SportCar()
    {
    }

    public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }
  }
}