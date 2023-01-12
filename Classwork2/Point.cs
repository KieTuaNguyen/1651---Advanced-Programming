namespace Classwork2
{
  class Point : Object
  {
    private int x;
    private int y;
    public int X
    {
      get { return x; }
      set { x = value; }
    }
    public int Y
    {
      get { return y; }
      set { y = value; }
    }
    public Point()
    {

    }
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public override string ToString()
    {
      return $"Point ({x},{y})";
    }
  }
}