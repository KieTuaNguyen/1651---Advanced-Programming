namespace Farm
{
  
   class Program
  {
    static void Main(string[] args)
    {
      /*Single inheritance*/
      Dog dog1 = new Dog();
      dog1.Bark();
      dog1.Bark();

      /*Multiple inheritance*/
      Puppy puppy1 = new Puppy();
      puppy1.Eat();
      puppy1.Bark();
      puppy1.Weep();

      /*Hierarchical inheritance*/
      Dog dog2 = new Dog();
      dog2.Eat();
      dog2.Bark();

      Cat cat1 = new Cat();
      cat1.Eat();
      cat1.Meow();
    }
  }
}