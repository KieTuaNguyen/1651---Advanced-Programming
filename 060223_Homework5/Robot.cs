namespace _060223_Homework5
{
  internal class Robot
  {
    //Auto implemented properties
    public string Model { get; set; }
    public string ID { get; set; }

    //Constructors
    public Robot()
    {
    }
    public Robot(string model, string id)
    {
      Model = model;
      ID = id;
    }
  }
}