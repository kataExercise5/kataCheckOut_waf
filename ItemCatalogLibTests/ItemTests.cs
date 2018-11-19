using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItemCatalogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCatalogLib.Tests
{
    [TestClass()]
    public class ItemTests
    {
        [TestMethod()]
        public void calcPriceTestForEach()
        {
            Item item = new Item("apples", .8m, Item.Units.each);
            Assert.IsTrue(item.calcPrice(3, new DateTime(2018, 11, 19)) == 2.4m);
        }

        [TestMethod()]
        public void calcPriceTestForPounds()
        {
            Item item = new Item("apples", 1m, Item.Units.pounds);
            Assert.IsTrue(item.calcPrice(3.5m, new DateTime(2018, 11, 19)) == 3.5m);
        }
    }
}