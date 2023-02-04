namespace _020223_Homework2;

public class Lizard : Reptile
{
  //Constructor
  public Lizard()
  {
  }
  public Lizard(string name) : base(name)
  {
    this.Name = "Lizard ";
  }

  public override string ToString()
  {
    return "Lizard is inherited from" + base.ToString();
  }
}