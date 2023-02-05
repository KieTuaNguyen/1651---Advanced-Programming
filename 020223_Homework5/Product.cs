namespace _020223_Homework5
{
  internal class Product
  {
    //Fields
    private string name;
    private decimal price;

    //Properties
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public decimal Price
    {
      get { return price; }
      set { price = value; }
    }

    //Constructors
    public Product()
    {

    }
    public Product(string name, decimal price)
    {
      Name = name;
      Price = price;
    }

    public override string ToString()
    {
      return $"Name: {Name} - Price: {Price}";
    }
  }
}