using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadCount_CreatesInstanceOfItem_Item()
    {
      int breadNumber = 0;
      BreadCount newBread = new BreadCount(breadNumber);
      int order = newBread.BreadNumber;
      Assert.AreEqual(breadNumber, order);
    }


    [TestMethod]
    public void Calculations_ReturnCost_Int()
    {
      int BreadNumber = 3;
      int cost = 10;
      BreadCount newBread = new BreadCount(BreadNumber);
      int order = BreadCount.Calculations(BreadNumber);
      Assert.AreEqual(cost, order);
    }

    [TestMethod]
    public void Calculations_ReturnCost_Int1()
    {
      int BreadNumber = 6;
      int cost = 20;
      BreadCount newBread = new BreadCount(BreadNumber);
      int order = BreadCount.Calculations(BreadNumber);
      Assert.AreEqual(cost, order); 
    }

    [TestMethod]
    public void Calculations_ReturnCost_int2()
    {
      int BreadNumber = 12;
      int cost = 40;
      BreadCount newBread = new BreadCount(BreadNumber);
      int order = BreadCount.Calculations(BreadNumber);
      Assert.AreEqual(cost, order);

    }
}
}