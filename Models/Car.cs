namespace Dealership.Models
{

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    // public void SetPrice(int newPrice)
    // {
    //   Price = newPrice;
    // }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}