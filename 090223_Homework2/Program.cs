namespace _090223_Homework2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());
      Vehicle[] vehicles = new Vehicle[n];
      for (int i = 0; i < n; i++)
      {
        string[] input = Console.ReadLine().Split();
        string type = input[0];
        double fuelQuantity = double.Parse(input[1]);
        double fuelConsumption = double.Parse(input[2]);
        double tankCapacity = double.Parse(input[3]);

        switch (type)
        {
          case "Car":
            vehicles[i] = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            break;
          case "Truck":
            vehicles[i] = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            break;
          case "Bus":
            vehicles[i] = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            break;
        }
      }

      int commandCount = int.Parse(Console.ReadLine());
      for (int i = 0; i < commandCount; i++)
      {
        string[] input = Console.ReadLine().Split();
        string command = input[0];
        string vehicleType = input[1];
        int index = -1;
        for (int j = 0; j < vehicles.Length; j++)
        {
          if (vehicles[j].GetType().Name == vehicleType)
          {
            index = j;
            break;
          }
        }

        switch (command)
        {
          case "Drive":
            double distance = double.Parse(input[2]);
            if (vehicleType == "Bus")
            {
              ((Bus)vehicles[index]).DriveWithPeople(distance);
            }
            else
            {
              vehicles[index].Drive(distance);
            }
            break;
          case "DriveEmpty":
            distance = double.Parse(input[2]);
            ((Bus)vehicles[index]).DriveEmpty(distance);
            break;
          case "Refuel":
            double liters = double.Parse(input[2]);
            if (liters <= 0)
            {
              Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
              vehicles[index].Refuel(liters);
            }
            break;
        }
      }

      foreach (Vehicle vehicle in vehicles)
      {
        Console.WriteLine(vehicle);
      }
    }
  }
}