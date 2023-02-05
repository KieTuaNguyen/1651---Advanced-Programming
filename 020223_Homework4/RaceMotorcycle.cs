namespace _020223_Homework4
{
  internal class RaceMotorcycle : Vehicle
  {
    public new static double DefaultFuelConsumption = 8;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;

    public RaceMotorcycle()
    {

    }

    public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }
  }
}