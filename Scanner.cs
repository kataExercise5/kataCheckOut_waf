using ItemCatalogLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerLib
{
    public class Scanner
    {
        private ItemCatalog itemCatalog;
        private Dictionary<int, decimal> openCheckOuts;
        private string errorMsg;
        public string getErrorMsg() { return errorMsg; }

        public Scanner()
        {
            itemCatalog = new ItemCatalog();
            openCheckOuts = new Dictionary<int, decimal>();
        }

        //ctor to support unit tests
        public Scanner(Dictionary<int, decimal> testSum)
        {
            itemCatalog = new ItemCatalog();
            openCheckOuts = testSum;
        }

        public bool initCheckOut(int checkOutNbr)
        {
            try
            {
                if (openCheckOuts.ContainsKey(checkOutNbr))
                {
                    openCheckOuts[checkOutNbr] = 0m;
                }
                else
                {
                    openCheckOuts.Add(checkOutNbr, 0m);
                }
                return true;
            }
            catch (Exception ex)
            {
                //use excp msg for now
                errorMsg = ex.Message;
                return false;
            }
        }

        public decimal getCheckOutTotal(int checkOutNbr)
        {
            decimal checkOutTotal;
            try
            {
                if (openCheckOuts.ContainsKey(checkOutNbr))
                {
                    checkOutTotal = openCheckOuts[checkOutNbr];
                }
                else
                {
                    checkOutTotal = 0m;
                }
                return checkOutTotal;
            }
            catch (Exception ex)
            {
                //exception handling tbd for now
                throw ex;
            }
        }

        public decimal checkOutItem(int checkOutNbr, string itemName, int qty)
        {
            if (!openCheckOuts.ContainsKey(checkOutNbr))
            {
                throw new Exception("This check out register has not been initialized.");
            }
            decimal itemTotalPrice = itemCatalog.calcPrice(itemName, qty, new DateTime(2018, 11, 19));
            openCheckOuts[checkOutNbr] = openCheckOuts[checkOutNbr] + itemTotalPrice;
            return itemTotalPrice;
        }

        public decimal checkOutItem(int checkOutNbr, string itemName, decimal pounds)
        {
            if (!openCheckOuts.ContainsKey(checkOutNbr))
            {
                throw new Exception("This check out register has not been initialized.");
            }
            decimal itemTotalPrice = itemCatalog.calcPrice(itemName, pounds, new DateTime(2018, 11, 19));
            openCheckOuts[checkOutNbr] = openCheckOuts[checkOutNbr] + itemTotalPrice;
            return itemTotalPrice;
        }
    }
}
