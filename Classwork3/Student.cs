namespace Classwork3
{
  internal class Student
  {
    private string name;
    private int age;

    private double grade;
    public string Name
    {
      get { return name; }
      set { name = value; }
    }
    public int Age
    {
      get { return age; }
      set { age = value; }
    }
    public double Grade
    {
      get { return grade; }
      set { grade = value; }
    }
    public Student(string name, int age, double grade)
    {
      Name = name;
      Age = age;
      Grade = grade;
    }
    public override string ToString()
    {
      return string.Format("Name: {0}, Age: {1}, Grade: {2}", Name, Age, Grade);
    }
  }
}