namespace _020223_Homework2;

public class Animal
{
  //Field
  string name;

  //Property
  public string Name { get => name; set => name = value; }


  //Constructor
  public Animal()
  {

  }
  public Animal(string name)
  {
    Name = name;
  }

  public override string ToString()
  {
    return "animal.";
  }
}