namespace _160223_Classwork1
{
  class Rectangle
  {
    public double length;
    public double width;
  }

  class Calculator
  {
    public double GetArea(Rectangle rect)
    {
      return rect.length * rect.width;
    }
  }

  class Triangle
  {
    public double baseT;
    public double height;
    public Triangle(int b, int h)
    {
      this.baseT = b;
      this.height = h;
    }
  }

  class CalculatorAdapter
  {
    public double GetArea(Triangle triangle)
    {
      Calculator calculator = new Calculator();
      Rectangle rect = new Rectangle();
      rect.length = triangle.baseT;
      rect.width = triangle.height / 2;
      return calculator.GetArea(rect);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Adapter Pattern");
      CalculatorAdapter adapter = new CalculatorAdapter();
      Triangle triangle = new Triangle(20, 10);
      Console.WriteLine("Area of Triangle: " + adapter.GetArea(triangle));
    }
  }
}