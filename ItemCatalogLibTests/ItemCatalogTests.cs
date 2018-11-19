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
    public class ItemCatalogTests
    {
        private ItemCatalog itemCatalog;
        private string applesItemName = "apples";
        private string tideItemName = "tide";

        [TestInitialize]
        public void TestInitialize()
        {
            Dictionary<string, Item> catalog = new Dictionary<string, Item>();
            
            Item item = new Item(applesItemName, .50m, Item.Units.pounds);
            catalog.Add(applesItemName, item);

            item = new Item(tideItemName, 4.77m, Item.Units.each);
            catalog.Add(tideItemName, item);

            itemCatalog = new ItemCatalog(catalog);
        }

        [TestMethod()]
        public void itemCatCalcPriceTestForEach()
        {
            decimal p = itemCatalog.calcPrice(tideItemName, 3, new DateTime(2018, 11, 19));
            Assert.IsTrue(itemCatalog.calcPrice(tideItemName, 3, new DateTime(2018, 11, 19)) == 14.31m);
        }

        [TestMethod()]
        public void itemCatCalcPriceTestForPounds()
        {
            Assert.IsTrue(itemCatalog.calcPrice(applesItemName, 2.6m, new DateTime(2018, 11, 19)) == 1.3m);
        }

        [TestCleanup]
        public void testCleanup()
        {
            itemCatalog = null;
            applesItemName = string.Empty;
            tideItemName = string.Empty;
    }
    }
}