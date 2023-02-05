namespace _020223_Homework6
{
  internal class StartUp
  {
      static void Main(string[] args)
      {
          var animals = new List<Animal>();
          string input;
          while ((input = Console.ReadLine()) != "Beast!")
          {
              var animalInfo = Console.ReadLine().Split();
              try
              {
                  switch (input)
                  {
                      case "Dog":
                          animals.Add(new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]));
                          break;
                      case "Cat":
                          animals.Add(new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]));
                          break;
                      case "Frog":
                          animals.Add(new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]));
                          break;
                      case "Kitten":
                          animals.Add(new Kitten(animalInfo[0], int.Parse(animalInfo[1])));
                          break;
                      case "Tomcat":
                          animals.Add(new TomCat(animalInfo[0], int.Parse(animalInfo[1])));
                          break;
                      default:
                          throw new ArgumentException("Invalid Input");
                  }
              }
              catch (Exception e)
              {
                  Console.WriteLine(e.Message);
              }
          }

          Console.WriteLine("--------------------------------");
          Console.WriteLine("Output:");
          Console.WriteLine("--------------------------------");
          foreach (var animal in animals)
          {
              Console.WriteLine(animal.ToString());
          }

      }
  }
}