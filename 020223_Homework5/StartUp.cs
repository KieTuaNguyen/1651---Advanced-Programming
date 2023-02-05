namespace _020223_Homework5
{
  internal class StartUp
  {
    static void Main(string[] args)
    {
      //Beverage
      Beverage beverage = new Beverage("Coca-Cola", 1.50m, 250);
      //Cake
      Cake cake = new Cake("Tiramisu");
      //Coffee
      Coffee coffee = new Coffee("Americano", 1.50m, 250, 50);
      //ColdBeverage
      ColdBeverage coldBeverage = new ColdBeverage("Cold Brew", 1.50m, 250);
      //Dessert
      Dessert dessert = new Dessert("Dessert", 1.50m, 250, 1000);
      //Fish
      Fish fish = new Fish("Fish", 1.50m);
      //Food
      Food food = new Food("Food", 1.50m, 250);
      //HotBeverage
      HotBeverage hotBeverage = new HotBeverage("Hot Beverage", 1.50m, 250);
      //MainDish
      MainDish mainDish = new MainDish("Main Dish", 1.50m, 250);
      //Soup
      Soup soup = new Soup("Soup", 1.50m, 250);
      //Starter
      Starter starter = new Starter("Starter", 1.50m, 250);
      //Tea
      Tea tea = new Tea("Tea", 1.50m, 250);

      //Print
      System.Console.WriteLine(beverage);
      System.Console.WriteLine(cake);
      System.Console.WriteLine(coffee);
      System.Console.WriteLine(coldBeverage);
      System.Console.WriteLine(dessert);
      System.Console.WriteLine(fish);
      System.Console.WriteLine(food);
      System.Console.WriteLine(hotBeverage);
      System.Console.WriteLine(mainDish);
      System.Console.WriteLine(soup);
      System.Console.WriteLine(starter);
      System.Console.WriteLine(tea);
    }
  }
}