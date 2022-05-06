using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Prices;
  public int Miles;

  public bool WorthBuying(int maxPrice)
  {
    return (Prices <= maxPrice);
  }

}

public class Program
{
  public static void Main()
  {


    Car volks = new Car();
    volks.MakeModel = "1975  volks";
    volks.Prices = 1200;
    volks.Miles = 386792;


    Car yugo = new Car();
    yugo.MakeModel = "1990 yugo";
    yugo.Prices = 1000;
    yugo.Miles = 900;


    Car gmc = new Car();
    gmc.MakeModel = "1990 gmc";
    gmc.Prices = 13000;
    gmc.Miles = 3900;

    Car cat = new Car();
    cat.MakeModel = "1990 cat";
    cat.Prices = 105500;
    cat.Miles = 977777;





    List<Car> cars = new List<Car>() { volks, yugo, gmc, cat };

    Console.WriteLine("Enter maximum price:");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);


    List<Car> carsMatchingSearch = new List<Car>();

    foreach (Car automobile in cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        carsMatchingSearch.Add(automobile);
      }
    }

    foreach (Car automobile in carsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }

  }
}
