namespace _060223_Homework5
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      string line;
      List<string> birthdayCitizen = new List<string>();
      List<string> birthdayPet = new List<string>();
      while ((line = Console.ReadLine()) != "End")
      {
        string[] input = line.Split(' ');
        if (input[0] != "Robot")
        {
          if (input[0] == "Citizen")
          {
            Citizen citizen = new Citizen(input[0], input[1], int.Parse(input[2]), input[3], input[4]);
            birthdayCitizen.Add(citizen.Birthday);
          }
          else
          {
            Pet pet = new Pet(input[0], input[1], input[2]);
            birthdayPet.Add(pet.Birthday);
          }
        }
      }

      string year = Console.ReadLine();
      int countEmpty = 0;
      foreach (var item in birthdayCitizen)
      {
        if (item.EndsWith(year))
        {
          Console.WriteLine(item);
          countEmpty++;
        }
      }
      foreach (var item in birthdayPet)
      {
        if (item.EndsWith(year))
        {
          Console.WriteLine(item);
          countEmpty++;
        }
      }
      if (countEmpty == 0)
      {
        Console.WriteLine("<empty output>");
      }
    }
  }
}