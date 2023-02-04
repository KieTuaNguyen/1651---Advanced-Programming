namespace _020223_Homework1
{
  internal class Child : Person
  {
    //Constructor
    public Child()
    {

    }

    public Child(string name, int age) : base(name, age)
    {
      System.Console.WriteLine("---");
      if (age > 15)
      {
        System.Console.WriteLine("Children should not have an age more than 15.");
        System.Console.WriteLine("Therefore, the maximum age assigned is 15.");
        Age = 15;
      }
      else
      {
        Age = age;
      }
      System.Console.WriteLine("---");
    }
    public override string ToString()
    {
      return "Child: " + base.ToString();
    }
  }
}