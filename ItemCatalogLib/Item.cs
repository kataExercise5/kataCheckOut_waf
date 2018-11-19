﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCatalogLib
{
    public class Item
    {
        public enum Units { each, pounds };
        private string itemName;
        private decimal itemPrice;
        private Units itemUnit;

        public Item(string name, decimal price, Units unit)
        {
            itemName = name;
            itemPrice = price;
            itemUnit = unit;
        }

        public decimal calcPrice(int qty, DateTime purchaseDate)
        {
            return qty * itemPrice;
        }

        public decimal calcPrice(decimal pounds, DateTime purchaseDate)
        {
            return pounds * itemPrice;
        }
    }
}
