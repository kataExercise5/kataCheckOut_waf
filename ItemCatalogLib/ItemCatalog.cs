using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCatalogLib
{
    public class ItemCatalog
    {
        private Dictionary<string, Item> catalog;

        public ItemCatalog()
        {
            loadCatalog();
        }

        //ctor to support unit tests
        public ItemCatalog(Dictionary<string, Item> cat)
        {
            catalog = cat;
        }

        private void loadCatalog()
        {
            catalog = new Dictionary<string, Item>();

            string itemName = "apples";
            Item item = new Item(itemName, .50m, Item.Units.each);
            catalog.Add(itemName, item);

            itemName = "tide";
            item = new Item(itemName, 4.77m, Item.Units.each);
            catalog.Add(itemName, item);
        }

        public decimal calcPrice(string itemName, int qty, DateTime purchaseDate)
        {
            Item item = findItemInCatalog(itemName);
            return item.calcPrice(qty, purchaseDate);
        }

        public decimal calcPrice(string itemName, decimal pounds, DateTime purchaseDate)
        {
            Item item = findItemInCatalog(itemName);
            return item.calcPrice(pounds, purchaseDate);
        }

        private Item findItemInCatalog(string itemName)
        {
            Item item;
            if (catalog.TryGetValue(itemName, out item))
            {
                return item;
            }
            throw new Exception("Item not found in catalog.");
        }
    }
}
