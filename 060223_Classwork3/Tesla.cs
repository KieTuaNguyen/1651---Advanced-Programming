namespace _060223_Classwork3
{
  internal class Tesla : ICar, IElectricCar
  {
    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }
    
    //Constructor
    public Tesla()
    {
      
    }
    
    public Tesla(string model, string color, int battery)
    {
      Model = model;
      Color = color;
      Battery = battery;
    }

    //To String method
    public override string ToString()
    {
      return $"{Color} Tesla {Model} with {Battery} batteries.";
    }

    public void Start()
    {
      Console.WriteLine("Engine start.");
    }

    public void Stop()
    {
      Console.WriteLine("Breaaak!");
    }

  }
}