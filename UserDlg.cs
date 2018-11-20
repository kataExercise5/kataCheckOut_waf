using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutDriver
{
    public partial class UserDlg : Form
    {
        public UserDlg()
        {
            InitializeComponent();
        }

        public void setDlgText(string msg)
        {
            userDlgTextBox.Text = msg;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
