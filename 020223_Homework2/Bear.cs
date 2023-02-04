namespace _020223_Homework2;

public class Bear : Mammal
{

  //Constructor
  public Bear()
  {
  }
  public Bear(string name) : base(name)
  {
    this.Name = "Bear ";
  }

  public override string ToString()
  {
    return "Bear is inherited from " + base.ToString();
  }
}