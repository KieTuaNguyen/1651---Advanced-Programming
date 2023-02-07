namespace _060223_Homework4
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      string line;
      List<string> idCitizen = new List<string>();
      List<string> idRobot = new List<string>();
      while ((line = Console.ReadLine()) != "End")
      {
        string[] input = line.Trim().Split(' ');
        if (input.Length == 3)
        {
          Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2]);
          idCitizen.Add(input[2]);
        }
        else if (input.Length == 2)
        {
          Robot robot = new Robot(input[0], input[1]);
          idRobot.Add(input[1]);
        }
      }
      string fakeId = Console.ReadLine();
      foreach (var citizens in idCitizen)
      {
        if (citizens.EndsWith(fakeId))
        {
          Console.WriteLine((string)citizens);
        }
      }
      foreach (var robots in idRobot)
      {
        if (robots.EndsWith(fakeId))
        {
          Console.WriteLine((string)robots);
        }
      }
    }
  }
}