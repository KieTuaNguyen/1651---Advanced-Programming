namespace _300123_Classwork2
{
  internal class Person
  {
    string name;
    int age;
    decimal salary;

    public string Name
    {
      get => name;
      set
      {
        if (value.Length > 3) name = value;
        else if (value.Length <= 0)
        {
          System.Console.WriteLine("Name cannot be empty.");
          Name = Console.ReadLine();
        }
        else
        {
          System.Console.WriteLine("Name must be at least 3 characters long.");
          Name = Console.ReadLine();
        }
      }
    }

    public int Age
    {
      get => age;
      set
      {
        if (value > 0) age = value;
        else if (value < 0)
        {
          System.Console.WriteLine("Age cannot be negative number.");
          Age = int.Parse(Console.ReadLine());
        }
        else
        {
          System.Console.WriteLine("Age must be greater than 0");
          Age = int.Parse(Console.ReadLine());
        }
      }
    }


    public decimal Salary
    {
      get => salary;
      set
      {
        if (value >= 460) salary = value;
        else if (value < 0)
        {
          System.Console.WriteLine("Salary cannot be negative number.");
          Salary = decimal.Parse(Console.ReadLine());
        }
        else
        {
          System.Console.WriteLine("Salary must be at least 460 dollars.");
          Salary = decimal.Parse(Console.ReadLine());
        }
      }
    }

    public Person(string name, int age, decimal salary)
    {
      Name = name;
      Age = age;
      Salary = salary;
    }

    public override string ToString()
    {
      return Name + " are " + Age + " years old and earns " + Salary + " dollars.";
    }
  }
}