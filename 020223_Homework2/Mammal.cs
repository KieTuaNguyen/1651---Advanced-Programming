namespace _020223_Homework2;

public class Mammal : Animal
{
  //Constructor
  public Mammal()
  {
  }
  public Mammal(string name) : base(name)
  {
    this.Name = "Mammal ";
  }

  public override string ToString()
  {
    return "Mammal, which is inherited from " + base.ToString();
  }

}