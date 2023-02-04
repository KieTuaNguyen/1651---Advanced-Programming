namespace _020223_Homework2;

public class Reptile : Animal
{
  //Constructor
  public Reptile()
  {
  }
  public Reptile(string name) : base(name)
  {
    this.Name = "Reptile ";
  }

  public override string ToString()
  {
    return "Reptile, which is inherited from " + base.ToString();
  }
}