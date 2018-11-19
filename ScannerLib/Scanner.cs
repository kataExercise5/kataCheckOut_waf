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
        private Dictionary<int, decimal> checkOutSummary;
        private string errorMsg;
        public string getErrorMsg() { return errorMsg; }

        public Scanner()
        {
            itemCatalog = new ItemCatalog();
            checkOutSummary = new Dictionary<int, decimal>();
        }

        //ctor to support unit tests
        public Scanner(Dictionary<int, decimal> testSum)
        {
            itemCatalog = new ItemCatalog();
            checkOutSummary = testSum;
        }

        public bool initCheckOut(int checkOutNbr)
        {
            try
            {
                if (checkOutSummary.ContainsKey(checkOutNbr))
                {
                    checkOutSummary[checkOutNbr] = 0m;
                }
                else
                {
                    checkOutSummary.Add(checkOutNbr, 0m);
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
                if (checkOutSummary.ContainsKey(checkOutNbr))
                {
                    checkOutTotal = checkOutSummary[checkOutNbr];
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

        public bool checkOutItem(int checkOutNbr, string itemName, int qty)
        {
            try
            {
                if (!checkOutSummary.ContainsKey(checkOutNbr))
                {
                    errorMsg = "This check out register has not been initialized.";
                    return false;
                }
                decimal itemTotalPrice = itemCatalog.calcPrice(itemName, qty, new DateTime(2018, 11, 19));
                checkOutSummary[checkOutNbr] = checkOutSummary[checkOutNbr] + itemTotalPrice;
                return true;
            }
            catch (Exception ex)
            {
                //use excp msg for now
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool checkOutItem(int checkOutNbr, string itemName, decimal pounds)
        {
            try
            {
                if (!checkOutSummary.ContainsKey(checkOutNbr))
                {
                    errorMsg = "This check out register has not been initialized.";
                    return false;
                }
                decimal itemTotalPrice = itemCatalog.calcPrice(itemName, pounds, new DateTime(2018, 11, 19));
                checkOutSummary[checkOutNbr] = checkOutSummary[checkOutNbr] + itemTotalPrice;
                return true;
            }
            catch (Exception ex)
            {
                //use excp msg for now
                errorMsg = ex.Message;
                return false;
            }
        }
    }
}
