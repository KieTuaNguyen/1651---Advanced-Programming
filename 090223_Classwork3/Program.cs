namespace _090223_Classwork3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Rectangle rectangle = new Rectangle(2, 3);
      Circle circle = new Circle(2);

      System.Console.WriteLine(rectangle.CalculateArea());
      System.Console.WriteLine(circle.CalculateArea());
    }
  }
}