namespace _020223_Homework2;

public class Gorilla : Mammal
{
  //Constructor
  public Gorilla()
  {
  }
  public Gorilla(string name) : base(name)
  {
    this.Name = "Gorilla ";
  }

  public override string ToString()
  {
    return "Gorilla is inherited from " + base.ToString();
  }
}