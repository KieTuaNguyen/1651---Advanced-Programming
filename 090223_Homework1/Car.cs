namespace _090223_Homework1
{
  class Car : Vehicle
  {
    public Car(double fuelQuantity, double litersPerKm)
        : base(fuelQuantity, litersPerKm + 0.9)
    {
    }
  }
}