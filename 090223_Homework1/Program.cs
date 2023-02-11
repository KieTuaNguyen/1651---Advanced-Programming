namespace _090223_Homework1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[] carInfo = Console.ReadLine().Split();
      string[] truckInfo = Console.ReadLine().Split();
      int n = int.Parse(Console.ReadLine());

      Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
      Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

      for (int i = 0; i < n; i++)
      {
        string[] commandInfo = Console.ReadLine().Split();
        string command = commandInfo[0];
        string vehicle = commandInfo[1];
        double distance = double.Parse(commandInfo[2]);

        if (command == "Drive")
        {
          if (vehicle == "Car")
          {
            car.Drive(distance);
          }
          else if (vehicle == "Truck")
          {
            truck.Drive(distance);
          }
        }
        else if (command == "Refuel")
        {
          if (vehicle == "Car")
          {
            car.Refuel(distance);
          }
          else if (vehicle == "Truck")
          {
            truck.Refuel(distance);
          }
        }
      }

      Console.WriteLine("Car: {0:F2}", car.FuelQuantity);
      Console.WriteLine("Truck: {0:F2}", truck.FuelQuantity);
    }
  }
}