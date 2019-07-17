using System;
using System.Collections.Generic;
namespace WildLifePark.Models
{
  class WildLife
  {
    private string _animal;
    private int _age;
    private string _gender;
    private int _count;
    public WildLife(string animal, int age, string gender, int count)
    {
      _animal = animal;
      _age = age;
      _gender = gender;
      _count = count;
    }
    public string GetAnimal()
    {
      return _animal;
    }
    public int GetCount()
    {
      return _count;
    }
    public int GetAge()
    {
      return _age;
    }

    public string GetGender()
    {
      return _gender;
    }
    public bool AgeCheck(int maxAge)
    {
      return (_age < maxAge);
    }
    
  }

}
