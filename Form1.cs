using ItemCatalogLib;
using ScannerLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheckoutDriver
{
    public partial class Form1 : Form
    {
        private Scanner scanner;
        private ItemCatalog itemCatalog;
        private List<Item> itemList;
        private Item selectedItem;
        private decimal price;
        private int selectedCheckOutNbr;
        private Dictionary<int, List<string>> checkOutItems;

        public Form1()
        {
            InitializeComponent();
            myInit();
        }

        private void myInit()
        {
            scanner = new Scanner();
            loadItems();
            checkOutItems = new Dictionary<int, List<string>>();
        }

        private void loadItems()
        {
            itemCatalog = new ItemCatalog();
            itemList = itemCatalog.getItems();
            foreach (Item item in itemList)
            {
                string listBoxStr = item.getItemName() + "  " +
                    item.getItemPrice().ToString() + " per " + item.getItemUnits();
                itemsListBox.Items.Add(listBoxStr);
            }
        }

        private void createCheckOutRegisterButton_Click(object sender, EventArgs e)
        {
            int checkOutNbr;
            if (Int32.TryParse(checkOutNbrTextBox.Text, out checkOutNbr))
            {
                if (scanner.initCheckOut(checkOutNbr))
                {
                    openCheckOutsComboBox.Items.Add(checkOutNbr);
                    openCheckOutsComboBox.SelectedIndex = openCheckOutsComboBox.Items.Count - 1;
                    selectedCheckOutNbr = checkOutNbr;
                }
                else
                {
                    showDlg("Scanner not available.  Msg=" + scanner.getErrorMsg());
                }
            }
            else
            {
                showDlg("Please enter a valid check out number (must be an integer).");
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = itemsListBox.SelectedIndex;
            if (n != -1)
            {
                selectedItem = itemList[n];
                if (selectedItem.isUnitsEach())
                {
                    qtyOrPoundsLabel.Text = "Quantity";
                }
                else
                {
                    qtyOrPoundsLabel.Text = "Pounds";
                }
            }
        }

        private void checkOutItemButton_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                showDlg("Please select an item.");
                return;
            }

            if (selectedItem.isUnitsEach())
            {
                calcItemPriceForEach();
            }
            else
            {
                calcItemPriceForPounds();
            }
            itemsListBox.SelectedIndex = -1;
            qtyOrPoundsTextBox.Text = string.Empty;
            decimal checkOutTotal = scanner.getCheckOutTotal(selectedCheckOutNbr);
            totalPurchaseAmtTextBox.Text = checkOutTotal.ToString();
        }

        private void calcItemPriceForEach()
        {
            int qty;
            if (int.TryParse(qtyOrPoundsTextBox.Text, out qty))
            {
                price = scanner.checkOutItem(selectedCheckOutNbr, selectedItem.getItemName(), qty);
                updatePurchasedList();
            }
            else
            {
                showDlg("'" + qtyOrPoundsTextBox.Text + "'" + " is not a valid quantity.");
            }
        }

        private void calcItemPriceForPounds()
        {
            decimal pounds;
            if (decimal.TryParse(qtyOrPoundsTextBox.Text, out pounds))
            {
                price = scanner.checkOutItem(selectedCheckOutNbr, selectedItem.getItemName(), pounds);
                updatePurchasedList();
            }
            else
            {
                showDlg("'" + qtyOrPoundsTextBox.Text+ "'"  + " is not a valid weight.");
            }
        }

        private void updatePurchasedList()
        {
            string purchaseInfo = selectedItem.getItemName() + " " +
                qtyOrPoundsTextBox.Text + " price=" + price;
            checkedOutItemsListBox.Items.Add(purchaseInfo);
        }

        private void showDlg(string msg)
        {
            UserDlg userDlg = new UserDlg();
            userDlg.setDlgText(msg);
            userDlg.ShowDialog();
        }

        private void openCheckOutsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (openCheckOutsComboBox.SelectedIndex != -1)
            {
                string checkOut = openCheckOutsComboBox.SelectedItem.ToString();
                int checkOutNbr;
                if (int.TryParse(checkOut, out checkOutNbr)) {
                    selectedCheckOutNbr = checkOutNbr;
                }
                else
                {
                    showDlg("Something is very wrong.");
                    openCheckOutsComboBox.Items.Clear();
                }
            }
        }
    }
}
