namespace _060223_Classwork3
{
  internal class Seat : ICar
  {
    public string Model { get; set; }
    public string Color { get; set; }
    
    //Constructors
    public Seat()
    {
      
    }

    public Seat(string model, string color)
    {
      Model = model;
      Color = color;
    }
    //To String method
    public override string ToString()
    {
      return $"{this.Color} Seat {this.Model}";
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