namespace _160223_Classwork1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      //Normal way
      School school1 = new School("Hogwarts", "1234 Hogwarts Way", "USA");
      Console.WriteLine(school1);

      School school2 = new School("Truong doi", "193 Nguyen Luong Bang", "Viet Nam");
      Console.WriteLine(school2);
      */

      /*
      //Singleton pattern
      School school1 = School.Instance;
      school1.Name = "Hogwarts";
      school1.Address = "1234 Hogwarts Way";
      school1.City = "USA";
      Console.WriteLine(school1);

      School school2 = School.Instance;
      school2.Name = "Truong doi";
      school2.Address = "193 Nguyen Luong Bang";
      school2.City = "Viet Nam";
      Console.WriteLine(school2);

      Console.WriteLine(school1);

      Console.WriteLine(school1.Equals(school2));
      */
    }
  }
}