using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 68, 100, .91);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 86, 150, .92);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 147, 200, .93);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 101, 175, .94);


      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      foreach (Car automobile in Cars)
      {
        automobile.DiscountCar();
      }

      Console.WriteLine("Enter maximum price:");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter how many years you plan to keep the car:");
      string stringDepreciationYears = Console.ReadLine();
      double depreciationYears = Double.Parse(stringDepreciationYears);


      List<Car> CarsMatchingSearch = new List<Car>(0);
      List<Car> CarsThatMakeIt = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach (Car automobile in Cars)
      {
        if (automobile.MaxRange > 160)
        {
          CarsThatMakeIt.Add(automobile);
        }
      }

      int fastestSpeed = 0;
      string fastestCar = "";

      foreach(Car automobile in CarsThatMakeIt)
      {
        if (automobile.MaxSpeed > fastestSpeed)
        {
          fastestCar = automobile.MakeModel;
          fastestSpeed = automobile.MaxSpeed;
        }
      }

      Console.WriteLine(fastestCar + " will win the Dakar Rally!");

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.MakeModel);
        Console.WriteLine(automobile.Miles + " miles");
        Console.WriteLine("$" + automobile.Price);
        Console.WriteLine(automobile.MaxSpeed + " mph");
        Console.WriteLine("Max Miles: " + automobile.MaxRange + " miles");
        Console.WriteLine("The Depreciated value in " + depreciationYears + " year(s) is: " + automobile.DepreciationValue(depreciationYears) + "$");
      }
    }
  } 
}