namespace kietAssignment1
{
  class Lecturer : Person
  {
    // Fields
    double salary;
    int hour;

    // Properties
    public double Salary
    {
      get { return salary; }
      set { salary = value; }
    }
    public int Hour
    {
      get { return hour; }
      set { hour = value; }
    }

    // Constructor
    public Lecturer()
    {
    }
    public Lecturer(string name, int age, string address, string phone, string email, double salary, int hour) : base(name, age, address, phone, email)
    {
      this.salary = salary;
      this.hour = hour;
    }

    // Methods
    public double CalSalary(int hour)
    {
      return hour * salary;
    }
    public void Status()
    {
      if (hour >= 40)
      {
        Console.WriteLine("Full time");
      }
      else
      {
        Console.WriteLine("Part time");
      }
    }

  }
}