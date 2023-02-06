namespace _060223_Classwork2
{
  internal class Rectangle : IDrawable
  {
    private int _width;
    private int _height;
    public int Width { get { return _width; } set { _width = value; } }
    public int Height { get { return _height; } set { _height = value; } }

    public Rectangle(int width, int height)
    {
      Width = width;
      Height = height;
    }

    public void Draw()
    {
      DrawLine(this.Width, '*', '*');
      for (int i = 1; i < this.Height - 1; ++i)
        DrawLine(this.Width, '*', ' ');
      DrawLine(this.Width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
      Console.Write(end);
      for (int i = 1; i < width - 1; ++i)
        Console.Write(mid);
      Console.WriteLine(end);
    }
  }
}