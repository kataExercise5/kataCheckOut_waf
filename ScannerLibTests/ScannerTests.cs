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
            checkOutSummary = new Dictionary<int, decimal>();
            checkOutSummary.Add(3, 0m);
            scanner = new Scanner(checkOutSummary);

            //init for ItemCatalog
            Dictionary<string, Item> catalog = new Dictionary<string, Item>();

            Item item = new Item(applesItemName, .50m, Item.Units.pounds);
            catalog.Add(applesItemName, item);

            item = new Item(tideItemName, 4.77m, Item.Units.each);
            catalog.Add(tideItemName, item);

            itemCatalog = new ItemCatalog(catalog);
        }

        [TestMethod()]
        public void initCheckOutTestNewNbr()
        {
            Assert.IsTrue(scanner.initCheckOut(4));
        }

        [TestMethod()]
        public void initCheckOutTestExistingNbr()
        {
            Assert.IsTrue(scanner.initCheckOut(3));
        }

        [TestMethod()]
        public void checkOutItemEachExists()
        {
            scanner.checkOutItem(3, tideItemName, 2);
            Assert.IsTrue(scanner.getCheckOutTotal(3) == 9.54m);
        }

        [TestMethod()]
        public void checkOutItemPoundsExists()
        {
            scanner.checkOutItem(3, applesItemName, 8.5m);
            Assert.IsTrue(scanner.getCheckOutTotal(3) == 4.25m);
        }
    }
}