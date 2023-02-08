namespace _060223_Homework6
{
  internal interface IBuyer
  {
    //Default method is public
    //Define properties
    int Food { get; set; }
    string Name { get; set; }

    //Define methods
    void BuyFood();
  }
}