namespace Classwork1
{

  class StarRhombus
  {
    public int size;
    public int Size { get; set; }
    public void PrintRow(int size, int starCount)
    {
      for (int i = 0; i < size - starCount; i++)
      {
        System.Console.Write(" ");
      }
      for (int i = 0; i < starCount; i++)
      {
        System.Console.Write("* ");
      }
      System.Console.WriteLine();
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      StarRhombus starRhombus = new StarRhombus();
      Console.Write("Enter the size of the rhombus: ");
      starRhombus.Size = int.Parse(Console.ReadLine());
      for (int i = 1; i <= starRhombus.Size; i++)
      {
        starRhombus.PrintRow(starRhombus.Size, i);
      }
      for (int i = starRhombus.Size - 1; i >= 1; i--)
      {
        starRhombus.PrintRow(starRhombus.Size, i);
      }
    }
  }
}