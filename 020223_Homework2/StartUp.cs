namespace _020223_Homework2
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      Animal animal = new Animal("Animal");
      Bear bear = new Bear("Bear");
      Gorilla gorilla = new Gorilla("Gorilla");
      Lizard lizard = new Lizard("Lizard");
      Mammal mammal = new Mammal("Mammal");
      Reptile reptile = new Reptile("Reptile");
      Snake snake = new Snake("Snake");

      System.Console.WriteLine(animal);
      Console.WriteLine("---");
      System.Console.WriteLine(reptile);
      System.Console.WriteLine(lizard);
      System.Console.WriteLine(snake);
      Console.WriteLine("---");      
      System.Console.WriteLine(mammal);
      System.Console.WriteLine(bear);
      System.Console.WriteLine(gorilla);
    }
  }
}