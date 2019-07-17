using System;
using System.Collections.Generic;
using WildLifePark.Models;
namespace WildLifePark
{
  public class Program
  {
    public static void Main()
    {
      WildLife Tiger = new WildLife("Bengal Tiger", 3, "Female", 2);
      WildLife Peacock = new WildLife("White peacock", 5, "Male", 2);
      WildLife Peahen = new WildLife("White peahen", 4, "Female", 1);
      WildLife Monkey = new WildLife("Mandrill", 2, "Female", 2);
      List<WildLife> Records = new List<WildLife>() { Tiger, Peacock, Peahen, Monkey };
      Console.WriteLine("Enter maximum Age: ");
      string stringAge = Console.ReadLine();
      int maxAge = int.Parse(stringAge);

      List<WildLife> Search = new List<WildLife>(0);

      foreach (WildLife animals in Records)
      {
        if (animals.AgeCheck(maxAge))
        {
          Search.Add(animals);
        }
      }

    foreach(WildLife animals in Search)
    {
      Console.WriteLine("----------------------");
      Console.WriteLine(animals.GetAnimal());
      Console.WriteLine(animals.GetAge() + " years");
      Console.WriteLine(animals.GetGender());
      Console.WriteLine("Count: "+animals.GetCount());
    }
    }
  }
}
