namespace Classwork2
{
  class Program
  {
    static void Main(string[] args)
    {
      Point point = new Point();
      Console.Write("Enter x: ");
      point.X = int.Parse(Console.ReadLine());
      Console.Write("Enter y: ");
      point.Y = int.Parse(Console.ReadLine());
      Console.WriteLine("Point: ({0},{1})", point.X, point.Y);
      Rectangle rectangle = new Rectangle();
      rectangle.TopLeft = new Point(0, 10);
      rectangle.BottomRight = new Point(10, 0);
      Console.WriteLine("The coordinates of the rectangle are: ({0},{1})", rectangle.TopLeft, rectangle.BottomRight);
      Console.WriteLine("Is point in rectangle: {0}", rectangle.IsContainsPoint(point));
    }
  }
}