namespace kietAssignment1
{
  class Rooms : School
  {
    // Fields
    int roomID;
    bool hasClass;

    // Properties
    public int RoomID
    {
      get { return roomID; }
      set { roomID = value; }
    }
    public bool HasClass
    {
      get { return hasClass; }
      set { hasClass = value; }
    }

    // Constructor
    public Rooms()
    {
    }
    public Rooms(int roomID, bool hasClass)
    {
      this.roomID = roomID;
      this.hasClass = hasClass;
    }
    // Methods
    public override void Display()
    {
      System.Console.WriteLine("ROOM INFORMATION: ");
      Console.WriteLine("RoomID\tRoomStatus");
      Console.WriteLine($"{roomID}\t{hasClass}");
    }

  }
}