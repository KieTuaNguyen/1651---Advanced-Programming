namespace kietAssignment1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a new Student1 object
      Student student1 = new Student("Kiet", 20, "Danang", "0123456789", "Kiet@email.com", 7, 1);
      // Create a new Student1 object
      Student student2 = new Student("Minh", 20, "Danang", "0122331245", "Minh@email.com", 8, 1);
      // Create a new Student1 object
      Student student3 = new Student("Chien", 20, "Danang", "012233864", "Chien@email.com", 8, 1);
      // Create a new Lecturer1 object
      Lecturer lecturer1 = new Lecturer("Thay Loi", 30, "Danang", "0123456789", "MrLoi@email.com", 1000, 40);

      // Display Student information
      student1.Print();
      student2.Print();
      student3.Print();

      // Display Lecturer information
      lecturer1.Print();

    }
  }
}