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

  }
}