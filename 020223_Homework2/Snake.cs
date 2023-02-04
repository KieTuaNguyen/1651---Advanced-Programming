namespace _020223_Homework2;

public class Snake : Reptile
{
  //Constructor
  public Snake()
  {
  }
  public Snake(string name) : base(name)
  {
    this.Name = "Snake ";
  }

  public override string ToString()
  {
    return "Snake is inherited from" + base.ToString();
  }
}