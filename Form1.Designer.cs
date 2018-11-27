namespace CheckoutDriver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createCheckOutRegisterButton = new System.Windows.Forms.Button();
            this.checkOutNbrTextBox = new System.Windows.Forms.TextBox();
            this.openCheckOutsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.checkOutItemLabel = new System.Windows.Forms.Label();
            this.qtyOrPoundsLabel = new System.Windows.Forms.Label();
            this.qtyOrPoundsTextBox = new System.Windows.Forms.TextBox();
            this.checkOutItemButton = new System.Windows.Forms.Button();
            this.checkedOutItemsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPurchaseAmtTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCheckOutRegisterButton
            // 
            this.createCheckOutRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCheckOutRegisterButton.Location = new System.Drawing.Point(33, 33);
            this.createCheckOutRegisterButton.Name = "createCheckOutRegisterButton";
            this.createCheckOutRegisterButton.Size = new System.Drawing.Size(170, 36);
            this.createCheckOutRegisterButton.TabIndex = 0;
            this.createCheckOutRegisterButton.Text = "Create CheckOut";
            this.createCheckOutRegisterButton.UseVisualStyleBackColor = true;
            this.createCheckOutRegisterButton.Click += new System.EventHandler(this.createCheckOutRegisterButton_Click);
            // 
            // checkOutNbrTextBox
            // 
            this.checkOutNbrTextBox.Location = new System.Drawing.Point(204, 33);
            this.checkOutNbrTextBox.Name = "checkOutNbrTextBox";
            this.checkOutNbrTextBox.Size = new System.Drawing.Size(56, 30);
            this.checkOutNbrTextBox.TabIndex = 1;
            // 
            // openCheckOutsComboBox
            // 
            this.openCheckOutsComboBox.FormattingEnabled = true;
            this.openCheckOutsComboBox.Location = new System.Drawing.Point(509, 31);
            this.openCheckOutsComboBox.Name = "openCheckOutsComboBox";
            this.openCheckOutsComboBox.Size = new System.Drawing.Size(89, 33);
            this.openCheckOutsComboBox.TabIndex = 2;
            this.openCheckOutsComboBox.SelectedIndexChanged += new System.EventHandler(this.openCheckOutsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Open Check Outs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(67, 173);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(229, 304);
            this.itemsListBox.TabIndex = 5;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // checkOutItemLabel
            // 
            this.checkOutItemLabel.AutoSize = true;
            this.checkOutItemLabel.Location = new System.Drawing.Point(83, 107);
            this.checkOutItemLabel.Name = "checkOutItemLabel";
            this.checkOutItemLabel.Size = new System.Drawing.Size(162, 25);
            this.checkOutItemLabel.TabIndex = 6;
            this.checkOutItemLabel.Text = "Check Out Item";
            // 
            // qtyOrPoundsLabel
            // 
            this.qtyOrPoundsLabel.AutoSize = true;
            this.qtyOrPoundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyOrPoundsLabel.Location = new System.Drawing.Point(214, 501);
            this.qtyOrPoundsLabel.Name = "qtyOrPoundsLabel";
            this.qtyOrPoundsLabel.Size = new System.Drawing.Size(36, 20);
            this.qtyOrPoundsLabel.TabIndex = 7;
            this.qtyOrPoundsLabel.Text = "Qty";
            // 
            // qtyOrPoundsTextBox
            // 
            this.qtyOrPoundsTextBox.Location = new System.Drawing.Point(294, 491);
            this.qtyOrPoundsTextBox.Name = "qtyOrPoundsTextBox";
            this.qtyOrPoundsTextBox.Size = new System.Drawing.Size(56, 30);
            this.qtyOrPoundsTextBox.TabIndex = 8;
            // 
            // checkOutItemButton
            // 
            this.checkOutItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutItemButton.Location = new System.Drawing.Point(19, 489);
            this.checkOutItemButton.Name = "checkOutItemButton";
            this.checkOutItemButton.Size = new System.Drawing.Size(170, 36);
            this.checkOutItemButton.TabIndex = 9;
            this.checkOutItemButton.Text = "Check Out Item";
            this.checkOutItemButton.UseVisualStyleBackColor = true;
            this.checkOutItemButton.Click += new System.EventHandler(this.checkOutItemButton_Click);
            // 
            // checkedOutItemsListBox
            // 
            this.checkedOutItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedOutItemsListBox.FormattingEnabled = true;
            this.checkedOutItemsListBox.ItemHeight = 20;
            this.checkedOutItemsListBox.Location = new System.Drawing.Point(369, 122);
            this.checkedOutItemsListBox.Name = "checkedOutItemsListBox";
            this.checkedOutItemsListBox.Size = new System.Drawing.Size(229, 304);
            this.checkedOutItemsListBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Purchased Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Purchase";
            // 
            // totalPurchaseAmtTextBox
            // 
            this.totalPurchaseAmtTextBox.Location = new System.Drawing.Point(527, 483);
            this.totalPurchaseAmtTextBox.Name = "totalPurchaseAmtTextBox";
            this.totalPurchaseAmtTextBox.Size = new System.Drawing.Size(95, 30);
            this.totalPurchaseAmtTextBox.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(45, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 567);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.openCheckOutsComboBox);
            this.tabPage1.Controls.Add(this.qtyOrPoundsTextBox);
            this.tabPage1.Controls.Add(this.checkOutItemButton);
            this.tabPage1.Controls.Add(this.qtyOrPoundsLabel);
            this.tabPage1.Controls.Add(this.totalPurchaseAmtTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.itemsListBox);
            this.tabPage1.Controls.Add(this.checkOutItemLabel);
            this.tabPage1.Controls.Add(this.checkedOutItemsListBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.checkOutNbrTextBox);
            this.tabPage1.Controls.Add(this.createCheckOutRegisterButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CheckOut";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Price Maintenance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 648);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createCheckOutRegisterButton;
        private System.Windows.Forms.TextBox checkOutNbrTextBox;
        private System.Windows.Forms.ComboBox openCheckOutsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label checkOutItemLabel;
        private System.Windows.Forms.Label qtyOrPoundsLabel;
        private System.Windows.Forms.TextBox qtyOrPoundsTextBox;
        private System.Windows.Forms.Button checkOutItemButton;
        private System.Windows.Forms.ListBox checkedOutItemsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalPurchaseAmtTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

