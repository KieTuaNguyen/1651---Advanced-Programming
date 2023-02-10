namespace kietAssignment1
{
  class Engine
  {
    // Auto implemented property
    public string Type { get; set; }

    //Constructor
    public Engine(string type)
    {
      Type = type;
    }
  }

  class Car
  {
    // Auto implemented properties
    public string Make { get; set; }
    public string Model { get; set; }

    //Instance of Engine class
    public Engine Engine { get; set; }

    // Constructor
    public Car(string make, string model, Engine engine)
    {
      Make = make;
      Model = model;
      Engine = engine;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Engine engine = new Engine("V8");
      Car car = new Car("Mercedes", "Maybach", engine);

      Console.WriteLine(car.Engine.Type);
    }
  }
}