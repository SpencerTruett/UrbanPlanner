using System;

namespace Planner
{
  public class Building
  {
    private string _designer = "Spencer Truett";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume
    {
      get
      {
        return 3 * Stories * Width * Depth;
      }
    }

    // Methods
    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }
    public void Purchase(string owner)
    {
      _owner = owner;

    }

    public void Description()
    {
      Console.WriteLine(this._address);
      Console.WriteLine($"-------------------");
      Console.WriteLine($"Designed by {this._designer}");
      Console.WriteLine($"Constructed on {this._dateConstructed}");
      Console.WriteLine($"Owned by {this._owner}");
      Console.WriteLine($"{this.Volume} cubic meters of space");
      Console.WriteLine("");
    }

    // Constructor
    public Building(string address, double width, double depth, int stories)
    {
      _address = address;
      Width = width;
      Depth = depth;
      Stories = stories;
    }

  }
}