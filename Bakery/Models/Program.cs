using System;
using System.Collections.Generic;
using Bakery.Models;  //import namespaces from Item.cs


namespace Bakery
{
public class Program
  {
    public static void Main()
    {
      Console.WriteLine( "Welcome! This is my little french bakery and I am excited to announce our special discount for today! Bread is always $5 while if you buy two the third is free, pastries are each $2 and a deal of $5 if you purchase 3 and so on! Enter 'B' for bread and/or 'P' for the pastries" );
      String order = Console.ReadLine().ToUpper();
      if ( order =="BP" || order == "PB")
      {
        Console.WriteLine("How much bread would you like to purchase?");
        int Loaf = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries?");
        int Pastry = int.Parse(Console.ReadLine());
        Console.WriteLine("The order total is!");
        PastryCount newPastryCount = new PastryCount(Pastry);
        int PastryResult = PastryCount.Calculations(newPastryCount.PastryNumber);
        BreadCount newBreadCount = new BreadCount(Loaf);
        int BreadResult = BreadCount.Calculations(newBreadCount.BreadNumber);
        Console.WriteLine(BreadResult+ PastryResult);


      }
      

    }
  }
}