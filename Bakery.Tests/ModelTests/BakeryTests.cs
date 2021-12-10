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
      int breadCount = 0;
      breadCount newBread = newBread(breadCount);
      int order = newBread.BreadNumber;
      Assert.AreEqual(breadCount, order);
    }

  }
}