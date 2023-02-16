namespace _160223_Classwork1
{
  class School
  {
    /*
    //Normal way
    //auto implemented properties
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    //constructor
    public School(string name, string address, string city)
    {
      Name = name;
      Address = address;
      City = city;
    }

    //method
    public override string ToString()
    {
      return Name + " " + Address + " " + City;
    }
    */

    /*
    //Singleton pattern
    private static School instance = null;
    private School()
    {
      // Constructor is marked private to prevent external instantiation
    }

    public static School Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new School();
        }
        return instance;
      }
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
      return Name + " " + Address + " " + City;
    }
    */
  }
}