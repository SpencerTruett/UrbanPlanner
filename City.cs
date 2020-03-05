using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    private string _name;
    private string _mayor;
    private int _yearEstablished;
    public void MayorElected(string mayor)
    {
      _mayor = mayor;

    }

    public List<Building> Buildings = new List<Building>();

    public void addBuilding(Building building)
    {
      Buildings.Add(building);
    }

    public City(string name, string mayor, int yearEstablished)
    {
      _name = name;
      _mayor = mayor;
      _yearEstablished = yearEstablished;
    }
  }
}