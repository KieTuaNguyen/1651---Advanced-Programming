using ConsoleApp3;

Song s = new Song();
Console.WriteLine("Enter the number of songs: ");
int numOfSongs = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the data in this format: {type list}_{name}_{time}: ");
List<Song> songs = new List<Song>();
Console.WriteLine("---------------------");
for (int i = 0; i < numOfSongs; i++)
{
  string[] data = Console.ReadLine().Split('_');
  Song song = new Song(data[0], data[1], data[2]);
  songs.Add(song);
}
Console.WriteLine("---------------------");
Console.WriteLine("Enter the type list: ");
string typeList = Console.ReadLine();
if (typeList == "all")
{
  foreach (Song song in songs)
  {
    Console.WriteLine(song.Name);
  }
}
else
{
  Console.WriteLine("Below are the songs included in the " + typeList + ": ");
  Console.WriteLine("---------------------");
  foreach (Song song in songs)
  {
    if (song.TypeList == typeList)
    {
      Console.WriteLine(song.Name);
    }
  }
}