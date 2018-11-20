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
            this.SuspendLayout();
            // 
            // createCheckOutRegisterButton
            // 
            this.createCheckOutRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCheckOutRegisterButton.Location = new System.Drawing.Point(12, 43);
            this.createCheckOutRegisterButton.Name = "createCheckOutRegisterButton";
            this.createCheckOutRegisterButton.Size = new System.Drawing.Size(170, 36);
            this.createCheckOutRegisterButton.TabIndex = 0;
            this.createCheckOutRegisterButton.Text = "Create CheckOut";
            this.createCheckOutRegisterButton.UseVisualStyleBackColor = true;
            this.createCheckOutRegisterButton.Click += new System.EventHandler(this.createCheckOutRegisterButton_Click);
            // 
            // checkOutNbrTextBox
            // 
            this.checkOutNbrTextBox.Location = new System.Drawing.Point(202, 43);
            this.checkOutNbrTextBox.Name = "checkOutNbrTextBox";
            this.checkOutNbrTextBox.Size = new System.Drawing.Size(56, 26);
            this.checkOutNbrTextBox.TabIndex = 1;
            // 
            // openCheckOutsComboBox
            // 
            this.openCheckOutsComboBox.FormattingEnabled = true;
            this.openCheckOutsComboBox.Location = new System.Drawing.Point(492, 43);
            this.openCheckOutsComboBox.Name = "openCheckOutsComboBox";
            this.openCheckOutsComboBox.Size = new System.Drawing.Size(89, 28);
            this.openCheckOutsComboBox.TabIndex = 2;
            this.openCheckOutsComboBox.SelectedIndexChanged += new System.EventHandler(this.openCheckOutsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Open Check Outs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(68, 174);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(229, 304);
            this.itemsListBox.TabIndex = 5;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // checkOutItemLabel
            // 
            this.checkOutItemLabel.AutoSize = true;
            this.checkOutItemLabel.Location = new System.Drawing.Point(81, 117);
            this.checkOutItemLabel.Name = "checkOutItemLabel";
            this.checkOutItemLabel.Size = new System.Drawing.Size(120, 20);
            this.checkOutItemLabel.TabIndex = 6;
            this.checkOutItemLabel.Text = "Check Out Item";
            // 
            // qtyOrPoundsLabel
            // 
            this.qtyOrPoundsLabel.AutoSize = true;
            this.qtyOrPoundsLabel.Location = new System.Drawing.Point(71, 504);
            this.qtyOrPoundsLabel.Name = "qtyOrPoundsLabel";
            this.qtyOrPoundsLabel.Size = new System.Drawing.Size(0, 20);
            this.qtyOrPoundsLabel.TabIndex = 7;
            // 
            // qtyOrPoundsTextBox
            // 
            this.qtyOrPoundsTextBox.Location = new System.Drawing.Point(241, 501);
            this.qtyOrPoundsTextBox.Name = "qtyOrPoundsTextBox";
            this.qtyOrPoundsTextBox.Size = new System.Drawing.Size(56, 26);
            this.qtyOrPoundsTextBox.TabIndex = 8;
            // 
            // checkOutItemButton
            // 
            this.checkOutItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutItemButton.Location = new System.Drawing.Point(68, 559);
            this.checkOutItemButton.Name = "checkOutItemButton";
            this.checkOutItemButton.Size = new System.Drawing.Size(170, 36);
            this.checkOutItemButton.TabIndex = 9;
            this.checkOutItemButton.Text = "Check Out Item";
            this.checkOutItemButton.UseVisualStyleBackColor = true;
            this.checkOutItemButton.Click += new System.EventHandler(this.checkOutItemButton_Click);
            // 
            // checkedOutItemsListBox
            // 
            this.checkedOutItemsListBox.FormattingEnabled = true;
            this.checkedOutItemsListBox.ItemHeight = 20;
            this.checkedOutItemsListBox.Location = new System.Drawing.Point(542, 174);
            this.checkedOutItemsListBox.Name = "checkedOutItemsListBox";
            this.checkedOutItemsListBox.Size = new System.Drawing.Size(229, 304);
            this.checkedOutItemsListBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Purchased Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Purchase";
            // 
            // totalPurchaseAmtTextBox
            // 
            this.totalPurchaseAmtTextBox.Location = new System.Drawing.Point(676, 512);
            this.totalPurchaseAmtTextBox.Name = "totalPurchaseAmtTextBox";
            this.totalPurchaseAmtTextBox.Size = new System.Drawing.Size(95, 26);
            this.totalPurchaseAmtTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 648);
            this.Controls.Add(this.totalPurchaseAmtTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedOutItemsListBox);
            this.Controls.Add(this.checkOutItemButton);
            this.Controls.Add(this.qtyOrPoundsTextBox);
            this.Controls.Add(this.qtyOrPoundsLabel);
            this.Controls.Add(this.checkOutItemLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openCheckOutsComboBox);
            this.Controls.Add(this.checkOutNbrTextBox);
            this.Controls.Add(this.createCheckOutRegisterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

