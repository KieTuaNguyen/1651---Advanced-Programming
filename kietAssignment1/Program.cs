namespace kietAssignment1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a new Student1 object
      Student student1 = new Student("Kiet", 20, "Danang", "0123456789", "Kiet@email.com", 7, 1);
      // Create a new Lecturer1 object
      Lecturer lecturer1 = new Lecturer("Thay Loi", 30, "Danang", "0123456789", "MrLoi@email.com", 1000, 40);

      // Display Student1 information
      Console.WriteLine("Student1 information:");
      student1.Info();
      student1.Status();

      // Display Lecturer1 information
      Console.WriteLine("Lecturer1 information:");
      lecturer1.Info();
      lecturer1.Status();

    }
  }
}