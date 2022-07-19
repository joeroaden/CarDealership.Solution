using System;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public double Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> {};
  

    public Car(string makeModel, double price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
     
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }

  }
}