using System.Collections.Generic;

namespace Music.Models
{
  public class Artists
  {
    public string Name { get; set; }
    // public int Id { get; }
    private static List<Item> _instances = new List<Item> { };

    public Artists(string artistName)
    {
      Name = artistName;
      _instances.Add(this);
      // Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }
  }
}