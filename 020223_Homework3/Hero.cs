namespace _020223_Homework3
{
  internal class Hero
  {
    //Field
    string username;
    int level;

    //Property
    public string Username { get => username; set => username = value; }
    public int Level { get => level; set => level = value; }

    //Constructor
    public Hero()
    {

    }
    public Hero(string username, int level)
    {
      Username = username;
      Level = level;
    }

    public override string ToString()
    {
      return $"Type: {this.GetType().Name} - Username: {this.Username} - Level: {this.Level}";
    }
  }
}