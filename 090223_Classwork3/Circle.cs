using _090223_Classwork2;

namespace _090223_Classwork3
{
  class Circle : Shape
  {
    //Fields
    double radius;

    //Properties
    public double Radius
    {
      get { return radius; }
      set { radius = value; }
    }

    //Constructors
    public Circle()
    {
    }
    public Circle(double radius)
    {
      this.radius = radius;
    }

    //Methods
    public override double Perimeter()
    {
      return 2 * radius * System.Math.PI;
    }

    public override double CalculateArea()
    {
      return radius * radius * System.Math.PI;
    }
  }

}