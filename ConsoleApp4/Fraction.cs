namespace ConsoleApp4
{
  internal class Fraction
  {
    //Field:
    private int numerator;
    private int denominator;

    //Properties:
    public int Numerator
    {
      set { numerator = value; }
      get { return numerator; }
    }
    public int Denominator
    {
      get { return denominator == 0 ? 1 : denominator; }
      set
      {
        if (value == 0)
          throw new InvalidOperationException("Denominator cannot be assigned a 0 Value.");
        denominator = value;
      }
    }

    //Constructors:
    public Fraction()
    {
    }
    public Fraction(int numerator, int denominator)
    {
      int GCD = this.GCD(numerator, denominator);
      Numerator = numerator / GCD;
      Denominator = denominator / GCD;
    }
    public int GCD(int x, int y)
    {
      if (y == 0) return x;
      else return GCD(y, x % y);
    }
    public void Print()
    {
      Console.WriteLine($"{Numerator}/{Denominator}");
    }

    public void Add(Fraction f, Fraction s)
    {
      int num = f.Numerator * s.Denominator + s.Numerator * f.Denominator;
      int den = f.Denominator * s.Denominator;
      Fraction result = new Fraction(num, den);
      result.Print();
    }
    public void Subtract(Fraction f, Fraction s)
    {
      int num = f.Numerator * s.Denominator - s.Numerator * f.Denominator;
      int den = f.Denominator * s.Denominator;
      Fraction result = new Fraction(num, den);
      result.Print();
    }
    public void Multiply(Fraction f, Fraction s)
    {
      int num = f.Numerator * s.Numerator;
      int den = f.Denominator * s.Denominator;
      Fraction result = new Fraction(num, den);
      result.Print();
    }
    public void Divide(Fraction f, Fraction s)
    {
      int num = f.Numerator * s.Denominator;
      int den = f.Denominator * s.Numerator;
      Fraction result = new Fraction(num, den);
      result.Print();
    }
    public void Decimal(Fraction f, Fraction s)
    {
      double Decimal = (double)numerator / denominator;
      Console.WriteLine(Decimal);
    }
  }
}