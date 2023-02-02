namespace _020223_Classwork1;

internal class Student : Person
{
  public string School { get; set; }

  public Student(string school)
  {
    School = school;
  }

  public Student(string name, string address, string school) : base(name, address)
  {
    School = school;
  }

  public override void Print()
  {
    base.Print();
    Console.WriteLine($"School: {School}");
  }


  // public override string ToString()
  // {
  //   return base.ToString() + $", School: {School}";
  // }
}