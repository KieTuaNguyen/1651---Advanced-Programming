using _090223_Classwork2;

namespace _090223_Classwork3
{
  class Rectangle : Shape
  {
    //Fields
    double width;
    double height;

    //Properties
    public double Width
    {
      get { return width; }
      set { width = value; }
    }
    public double Height
    {
      get { return height; }
      set { height = value; }
    }

    //Constructors
    public Rectangle()
    {
    }
    public Rectangle(double width, double height)
    {
      this.width = width;
      this.height = height;
    }

    //Methods
    public override double Perimeter()
    {
      return 2 * (width + height);
    }
    public override double CalculateArea()
    {
      return width * height;
    }
  }
}