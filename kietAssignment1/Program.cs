namespace kietAssignment1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a new school object
      School school;
      school = new Student("Kiet", 20, "Danang", "0123456789", "Kiet@email.com", 7, 1);
      school.Display();
      school = new Rooms(302, true);
      school.Display();
    }
  }
}