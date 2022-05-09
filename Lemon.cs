using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Prices;
  public int Miles;

  public Car(string makeModel, int price, int miles)

  {
    MakeModel = makeModel;
    Prices = price;
    Miles = miles;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Prices <= maxPrice);
  }

}

public class Program
{
  public static void Main()
  {


    Car volks = new Car("1975  volks", 1200, 34567);
    Car yugo = new Car("1990 yugo", 1000, 900);
    Car gmc = new Car("1990 gmc", 13000, 3900);
    Car cat = new Car("1990 cat", 105500, 977777);



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
