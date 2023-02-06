namespace _060223_Classwork2
{
  internal class Circle : IDrawable
  {
    double _radius;
    public double Radius { get { return _radius; } set { _radius = value; } }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public void Draw()
    {
      double rIn = this.Radius - 0.4;
      double rOut = this.Radius + 0.4;
      for (double y = this.Radius; y >= -this.Radius; --y)
      {
        for (double x = -this.Radius; x < rOut; x += 0.5)
        {
          double value = x * x + y * y;
          if (value >= rIn * rIn && value <= rOut * rOut)
            Console.Write("*");
          else
            Console.Write(" ");
        }
        Console.WriteLine();
      }
    }
  }
}