namespace _060223_Classwork1
{
  public abstract class Animal
  {
    //Auto implemented properties
    public string Name { get; set; }

    public abstract void Sleep();

    //Define an abstract method Eat(), the parent class must be abstract class
    //Purpost of abstract method is to be inherited by child class
    public abstract void Eat();

    //Constructor
    public Animal(string name)
    {
      Name = name;
    }
  }
}