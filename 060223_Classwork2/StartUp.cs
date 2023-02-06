namespace _060223_Classwork2
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      Circle circle = new Circle(5);
      circle.Draw();

      Console.WriteLine();

      Rectangle rectangle = new Rectangle(20, 5);
      rectangle.Draw();
    }
  }
}