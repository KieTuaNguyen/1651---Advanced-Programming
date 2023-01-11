namespace ConsoleApp3
{
  internal class Song
  {
    //Field
    private string typeList;
    private string name;
    private string time;
    
    //Properties
    public string TypeList
    {
      set { typeList = value; }
      get { return typeList; }
    }
    public string Name
    {
      set { name = value; }
      get { return name; }
    }
    public string Time
    {
      set { time = value; }
      get { return time; }
    }

    public Song()
    {
      
    }
    public Song(string typeList, string name, string time)
    {
      TypeList = typeList;
      Name = name;
      Time = time;
    }
  }
}