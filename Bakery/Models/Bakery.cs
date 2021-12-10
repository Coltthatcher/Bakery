using System.Collections.Generic;
namespace Bakery.Models
{
  public class BreadCount
  {

    public int BreadNumber {get; set;}

    public BreadCount(int breadNumber)
    {
      BreadNumber = breadNumber;
    }


    public static int Calculations(int breadNumber)
    {
      int cost = 0;
      int freeBread = breadNumber / 3;
      int remainder = breadNumber % 3;
      if (breadNumber < 2)
      {
        cost = breadNumber * 5;
      }
      else 
      {
        cost = (breadNumber - freeBread)* 5;
      }
      return 10;
    }
  }







}



/* Bread:Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
you need to have a variable for bread at $5
you need a start value of 0 to start the price off 
you need buy 2x get on 1x free 
3x - 2x= x 15 - 
int cost = 5;
int a = numOfProductA();
int b = numOfProductB();
int total = a + b;
int totalFree = total/3;
int totalCost = (total - totalFree)*cost;
a method to 

if you buy 3 bread the price should be equal to 10 
int breadNumber = 3 
int cost - 10
int for freeBread



*/

