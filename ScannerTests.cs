using ItemCatalogLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScannerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLib.Tests
{
    [TestClass()]
    public class ScannerTests
    {
        private Dictionary<int, decimal> checkOutSummary;
        private Scanner scanner;

        //attributes for ItemCatalog
        private ItemCatalog itemCatalog;
        private string applesItemName = "apples";
        private string tideItemName = "tide";

        [TestInitialize]
        public void TestInitialize()
        {
            //checkOutSummary = new Dictionary<int, decimal>();
            //checkOutSummary.Add(3, 0m);
            //scanner = new Scanner(checkOutSummary);

            //init for ItemCatalog
            Dictionary<string, Item> catalog = new Dictionary<string, Item>();

            Item item = new Item(applesItemName, .50m, Item.Units.pounds);
            catalog.Add(applesItemName, item);

            item = new Item(tideItemName, 4.77m, Item.Units.each);
            catalog.Add(tideItemName, item);

            itemCatalog = new ItemCatalog(catalog);

            scanner = new Scanner(itemCatalog);
            scanner.initCheckOut(4);
        }

        [TestMethod()]
        public void initCheckOutTestNewNbr()
        {
            Assert.IsTrue(scanner.initCheckOut(5));
        }

        [TestMethod()]
        public void initCheckOutTestExistingNbr()
        {
            Assert.IsTrue(scanner.initCheckOut(4));
        }

        [TestMethod()]
        public void checkOutItemEachExists()
        {
            Assert.IsTrue(scanner.checkOutItem(4, tideItemName, 2) == 9.54m);
            Assert.IsTrue(scanner.getCheckOutTotal(4) == 9.54m);
        }

        [TestMethod()]
        public void checkOutItemPoundsExists()
        {
            Assert.IsTrue(scanner.checkOutItem(4, applesItemName, 8.5m) == 4.25m);
            Assert.IsTrue(scanner.getCheckOutTotal(4) == 4.25m);
        }

        [TestMethod()]
        public void checkOutItemExistsWithMultipleItems()
        {
            Assert.IsTrue(scanner.checkOutItem(4, applesItemName, 8.5m) == 4.25m);
            Assert.IsTrue(scanner.checkOutItem(4, tideItemName, 2) == 9.54m);
            Assert.IsTrue(scanner.getCheckOutTotal(4) == 13.79m);
        }

        [TestMethod()]
        public void checkOutItemCheckOutStationNotInitialized()
        {
            try
            {
                decimal price = scanner.checkOutItem(3, applesItemName, 2);
                Assert.Fail();
            }
            catch (Exception ex)
            {
            }
        }

        [TestMethod()]
        public void checkOutItemDoesNotExist()
        {
            try
            {
                decimal price = scanner.checkOutItem(4, "unknown", 2);
                Assert.Fail();
            }
            catch (Exception ex)
            {
            }
        }

        [TestMethod()]
        public void checkOutItemWithMultipleCheckOutStations()
        {
            scanner.initCheckOut(7);
            scanner.initCheckOut(8);
            Assert.IsTrue(scanner.checkOutItem(7, applesItemName, 8.5m) == 4.25m);
            Assert.IsTrue(scanner.checkOutItem(8, applesItemName, 3.6m) == 1.8m);
            Assert.IsTrue(scanner.checkOutItem(7, tideItemName, 2) == 9.54m);
            Assert.IsTrue(scanner.checkOutItem(8, tideItemName, 1) == 4.77m);
            Assert.IsTrue(scanner.getCheckOutTotal(7) == 13.79m);
            Assert.IsTrue(scanner.getCheckOutTotal(8) == 6.57m);
        }
    }
}