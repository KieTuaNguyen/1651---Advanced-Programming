namespace _020223_Classwork1;

internal class Person
{
  public string Name { get; set; }
  public string Address { get; set; }

  public Person()
  {

  }

  public Person(string name, string address)
  {
    Name = name;
    Address = address;
  }

  public virtual void Print()
  {
    Console.WriteLine($"Name: {Name}, Address: {Address}");
  }

  public override string ToString()
  {
    return $"Name: {Name}, Address: {Address}";
  }
}