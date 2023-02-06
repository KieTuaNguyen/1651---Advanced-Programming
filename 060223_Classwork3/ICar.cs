namespace _060223_Classwork3
{
  internal interface ICar
  {
    //Auto implemented properties
    public string Model { get; set; }
    public string Color { get; set; }

    //Default method is public
    void Start();
    void Stop();
  }
}