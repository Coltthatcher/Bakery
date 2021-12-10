using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Pastry.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryCount_CreatesInstanceOfItem_Item()
    {
      int pastryNumber = 0;
      PastryCount newPastry = new PastryCount(pastryNumber);
      int order = newPastry.PastryNumber;
      Assert.AreEqual(pastryNumber, order);
    }

    [TestMethod]
    public void Calculations_ReturnCost_Int()
    {
      int PastryNumber = 1;
      int cost = 2;
      PastryCount newPastry = new PastryCount(PastryNumber);
      int order = PastryCount.Calculations(PastryNumber);
      Assert.AreEqual(cost, order);

    }
    
    
  }
}