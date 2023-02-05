namespace _020223_Homework4
{
  internal class Car : Vehicle
  {
    public new static double DefaultFuelConsumption = 3;
    public override double FuelConsumption { get; set; } = DefaultFuelConsumption;

    public Car()
    {
    }

    public Car(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }
  }
}