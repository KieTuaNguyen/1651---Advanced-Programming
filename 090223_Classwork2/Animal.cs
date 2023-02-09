namespace _090223_Classwork2
{
  internal class Animal
  {
    //Fields
    string name;
    string favoriteFood;

    //Properties
    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        name = value;
      }
    }
    public string FavoriteFood
    {
      get
      {
        return favoriteFood;
      }
      set
      {
        favoriteFood = value;
      }
    }

    //Constructors
    public Animal()
    {
    }
    public Animal(string name, string favoriteFood)
    {
      this.name = name;
      this.favoriteFood = favoriteFood;
    }

    //Methods
    public virtual string ExplainSelf()
    {
      return $"I am {name} and my fovorite food is {favoriteFood}";
    }
  }
}