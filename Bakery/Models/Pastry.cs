using System.Collections.Generic;
namespace Bakery.Models
{

  public class PastryCount
  {
    public int PastryNumber {get; set;}


    public PastryCount(int pastryNumber)
    {
      PastryNumber = pastryNumber;
    }

    public static int Calculations(int pastryNumber)
    {
      int cost = 0;
      if (pastryNumber < 3)
      {
        cost = pastryNumber * 2;
      }
      return cost;
    }
  }
}