using System;
using System.Collections.Generic;
namespace WildLifePark.Models
{
  class WildLife
  {
    private string _animal;
    private int _age;
    private string _gender;


    public Car(string animal, int age, string gender)
    {
      _animal = animal;
      _age = age;
      _gender = gender;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public static string MakeSound(string sound)
        {
            return "Our cars sound like " + sound;
        }
  }
}
