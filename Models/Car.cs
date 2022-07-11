using System;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public double Price { get; set; }
    public int Miles { get; set; }
    public int MaxSpeed { get; set; }
    public int MaxRange { get; set; }
    public double DepreciationRate { get; set; }

    public Car(string makeModel, double price, int miles, int maxSpeed, int maxRange, double depreciationRate)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      MaxSpeed = maxSpeed;
      MaxRange = maxRange;
      DepreciationRate = depreciationRate;
    }
       
    public bool WorthBuying(double maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public void DiscountCar()
    {
      Price = Math.Round((Double)(Price * .75), 2);
    }

    public double DepreciationValue(double loopLength)
    {
      double depreciatedValue = Math.Round((Double)(Price * DepreciationRate), 2);
      for (int index = 0; index < loopLength; index++)
      {
        depreciatedValue = Math.Round((Double)(depreciatedValue * DepreciationRate), 2);
      } 
      return depreciatedValue;     
    }
  }
}