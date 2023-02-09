namespace kietAssignment1
{
  class Person : School
  {
    // Fields
    string name;
    int age;
    string address;
    string phone;
    string email;

    // Properties
    public virtual string Name
    {
      get { return name; }
      set { name = value; }
    }
    public virtual int Age
    {
      get { return age; }
      set { age = value; }
    }
    public virtual string Address
    {
      get { return address; }
      set { address = value; }
    }
    public virtual string Phone
    {
      get { return phone; }
      set { phone = value; }
    }
    public virtual string Email
    {
      get { return email; }
      set { email = value; }
    }

    // Constructor
    public Person()
    {
    }
    public Person(string name, int age, string address, string phone, string email)
    {
      this.name = name;
      this.age = age;
      this.address = address;
      this.phone = phone;
      this.email = email;
    }

    // Methods
    public void Info()
    {
      Console.WriteLine($"Name: " + name + " - Age: " + age + " - Address: " + address + " - Phone: " + phone + " - Email: " + email);
    }
    public virtual void Print()
    {
      System.Console.WriteLine("PERSONAL INFORMATION: ");
      Console.WriteLine("Name\tAge\tAddress\t\tPhone\t\tEmail");
      Console.WriteLine($"{Name}\t{Age}\t{Address}\t\t{Phone}\t{Email}");
    }

    // Override
    public override void Display()
    {
      System.Console.WriteLine("PERSONAL INFORMATION: ");
      Console.WriteLine("Name\tAge\tAddress\t\tPhone\t\tEmail");
      Console.WriteLine($"{Name}\t{Age}\t{Address}\t\t{Phone}\t{Email}");
    }
  }
}