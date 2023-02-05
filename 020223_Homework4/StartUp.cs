namespace _020223_Homework4
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      Vehicle vehicle = new Vehicle(100, 100);
      vehicle.Drive(10);
      Console.WriteLine(vehicle);

      Car car = new Car(100, 100);
      car.Drive(10);
      Console.WriteLine(car);

      SportCar sportCar = new SportCar(100, 100);
      sportCar.Drive(10);
      Console.WriteLine(sportCar);

      FamilyCar familyCar = new FamilyCar(100, 100);
      familyCar.Drive(10);
      Console.WriteLine(familyCar);

      Motorcycle motorcycle = new Motorcycle(100, 100);
      motorcycle.Drive(10);
      Console.WriteLine(motorcycle);

      CrossMotorcycle crossMotorcycle = new CrossMotorcycle(100, 100);
      crossMotorcycle.Drive(10);
      Console.WriteLine(crossMotorcycle);

      RaceMotorcycle raceMotorcycle = new RaceMotorcycle(100, 100);
      raceMotorcycle.Drive(10);
      Console.WriteLine(raceMotorcycle);

    }
  }
}