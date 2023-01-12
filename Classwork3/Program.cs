namespace Classwork3
{
  class Program
  {
    static void Main(string[] args)
    {
      Function function = new Function();
      Console.WriteLine("Choose the function below");
      function.Menu();
      Console.Write("Enter your choice: ");
      int choice = int.Parse(Console.ReadLine());
      Console.WriteLine("--------------------");
      do
      {
        if (choice == 1)
        {
          function.AddAStudentToList();
        }
        else if (choice == 2)
        {
          Console.Write("Enter student name: ");
          string studentName = Console.ReadLine();
          Console.WriteLine("*****");
          function.FindByName(studentName);
        }
        else if (choice == 3)
        {
          Console.WriteLine("End the program!");
          Console.WriteLine("*****");
          break;
        }
        else
        {
          Console.WriteLine("Invalid choice! Please try again!");
          Console.WriteLine("*****");
        }
        function.Menu();
        Console.Write("Enter your choice: ");
        choice = int.Parse(Console.ReadLine());
      }
      while (true);
      Console.ReadLine();
    }
  }
}