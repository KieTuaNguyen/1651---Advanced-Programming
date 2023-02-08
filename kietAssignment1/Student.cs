namespace kietAssignment1
{
  class Student : Person
  {
    //Fields
    double score;
    int grade;

    // Properties
    public double Score
    {
      get { return score; }
      set { score = value; }
    }
    public int Grade
    {
      get { return grade; }
      set { grade = value; }
    }

    // Constructor
    public Student()
    {
    }
    public Student(string name, int age, string address, string phone, string email, double score, int grade) : base(name, age, address, phone, email)
    {
      this.score = score;
      this.grade = grade;
    }

    // Methods
    public void Status()
    {
      if (score >= 5)
      {
        Console.WriteLine("Pass");
      }
      else
      {
        Console.WriteLine("Fail");
      }
    }
  }
}