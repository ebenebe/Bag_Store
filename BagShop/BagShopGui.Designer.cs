namespace BagShop
{
    partial class BagShopGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BagShopGui));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOrderViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblBagSelection = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmboBxQuantity = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBxStandard = new System.Windows.Forms.RadioButton();
            this.radBx3Day = new System.Windows.Forms.RadioButton();
            this.radBxOvernight = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxShippmentFee = new System.Windows.Forms.TextBox();
            this.txtBxTotalPayment = new System.Windows.Forms.TextBox();
            this.cmboBxBags = new System.Windows.Forms.ComboBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitFileMenu});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            this.fileMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(152, 22);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exitFileMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearOrderEditMenu});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "&Edit";
            // 
            // clearOrderEditMenu
            // 
            this.clearOrderEditMenu.Name = "clearOrderEditMenu";
            this.clearOrderEditMenu.Size = new System.Drawing.Size(152, 22);
            this.clearOrderEditMenu.Text = "Clear Order";
            this.clearOrderEditMenu.Click += new System.EventHandler(this.clearOrderEditMenu_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOrderViewMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "&View";
            // 
            // displayOrderViewMenuItem
            // 
            this.displayOrderViewMenuItem.Name = "displayOrderViewMenuItem";
            this.displayOrderViewMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayOrderViewMenuItem.Text = "Display Order";
            this.displayOrderViewMenuItem.Click += new System.EventHandler(this.displayOrderViewMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(208, 27);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(162, 26);
            this.txtBxName.TabIndex = 0;
            // 
            // lblBagSelection
            // 
            this.lblBagSelection.AutoSize = true;
            this.lblBagSelection.Location = new System.Drawing.Point(12, 65);
            this.lblBagSelection.Name = "lblBagSelection";
            this.lblBagSelection.Size = new System.Drawing.Size(116, 20);
            this.lblBagSelection.TabIndex = 4;
            this.lblBagSelection.Text = "Bags Selection";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(165, 56);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(117, 20);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Select Quantity";
            // 
            // cmboBxQuantity
            // 
            this.cmboBxQuantity.FormattingEnabled = true;
            this.cmboBxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboBxQuantity.Location = new System.Drawing.Point(169, 88);
            this.cmboBxQuantity.Name = "cmboBxQuantity";
            this.cmboBxQuantity.Size = new System.Drawing.Size(121, 28);
            this.cmboBxQuantity.TabIndex = 2;
            this.cmboBxQuantity.SelectedIndexChanged += new System.EventHandler(this.cmboBxQuantity_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Add to Cart";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = " Price";
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.AcceptsReturn = true;
            this.txtBxPrice.Location = new System.Drawing.Point(334, 88);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.ReadOnly = true;
            this.txtBxPrice.Size = new System.Drawing.Size(100, 26);
            this.txtBxPrice.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBxStandard);
            this.groupBox1.Controls.Add(this.radBx3Day);
            this.groupBox1.Controls.Add(this.radBxOvernight);
            this.groupBox1.Location = new System.Drawing.Point(7, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shippment Type";
            // 
            // radBxStandard
            // 
            this.radBxStandard.AutoSize = true;
            this.radBxStandard.Location = new System.Drawing.Point(5, 76);
            this.radBxStandard.Name = "radBxStandard";
            this.radBxStandard.Size = new System.Drawing.Size(129, 24);
            this.radBxStandard.TabIndex = 13;
            this.radBxStandard.TabStop = true;
            this.radBxStandard.Text = "Standard - 5%";
            this.radBxStandard.UseVisualStyleBackColor = true;
            this.radBxStandard.CheckedChanged += new System.EventHandler(this.ShippmentType_CheckedChanged);
            // 
            // radBx3Day
            // 
            this.radBx3Day.AutoSize = true;
            this.radBx3Day.Location = new System.Drawing.Point(6, 46);
            this.radBx3Day.Name = "radBx3Day";
            this.radBx3Day.Size = new System.Drawing.Size(104, 24);
            this.radBx3Day.TabIndex = 12;
            this.radBx3Day.TabStop = true;
            this.radBx3Day.Text = "3 Day - 7%";
            this.radBx3Day.UseVisualStyleBackColor = true;
            this.radBx3Day.CheckedChanged += new System.EventHandler(this.ShippmentType_CheckedChanged);
            // 
            // radBxOvernight
            // 
            this.radBxOvernight.AutoSize = true;
            this.radBxOvernight.Location = new System.Drawing.Point(6, 25);
            this.radBxOvernight.Name = "radBxOvernight";
            this.radBxOvernight.Size = new System.Drawing.Size(142, 24);
            this.radBxOvernight.TabIndex = 11;
            this.radBxOvernight.TabStop = true;
            this.radBxOvernight.Text = "OverNight - 10%";
            this.radBxOvernight.UseVisualStyleBackColor = true;
            this.radBxOvernight.CheckedChanged += new System.EventHandler(this.ShippmentType_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Shippment Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Payment";
            // 
            // txtBxShippmentFee
            // 
            this.txtBxShippmentFee.Location = new System.Drawing.Point(454, 88);
            this.txtBxShippmentFee.Name = "txtBxShippmentFee";
            this.txtBxShippmentFee.ReadOnly = true;
            this.txtBxShippmentFee.Size = new System.Drawing.Size(100, 26);
            this.txtBxShippmentFee.TabIndex = 13;
            // 
            // txtBxTotalPayment
            // 
            this.txtBxTotalPayment.Location = new System.Drawing.Point(577, 90);
            this.txtBxTotalPayment.Name = "txtBxTotalPayment";
            this.txtBxTotalPayment.ReadOnly = true;
            this.txtBxTotalPayment.Size = new System.Drawing.Size(100, 26);
            this.txtBxTotalPayment.TabIndex = 14;
            // 
            // cmboBxBags
            // 
            this.cmboBxBags.FormattingEnabled = true;
            this.cmboBxBags.Location = new System.Drawing.Point(13, 88);
            this.cmboBxBags.Name = "cmboBxBags";
            this.cmboBxBags.Size = new System.Drawing.Size(121, 28);
            this.cmboBxBags.TabIndex = 1;
            this.cmboBxBags.SelectedIndexChanged += new System.EventHandler(this.cmboBxBags_SelectedIndexChanged);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToOrderColumns = true;
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(170, 132);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTable.Size = new System.Drawing.Size(549, 115);
            this.dataGridViewTable.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // BagShopGui
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(746, 447);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.cmboBxBags);
            this.Controls.Add(this.txtBxTotalPayment);
            this.Controls.Add(this.txtBxShippmentFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmboBxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBagSelection);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BagShopGui";
            this.Text = "Bag Shop";
            this.Load += new System.EventHandler(this.BagShopGui_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOrderEditMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOrderViewMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblBagSelection;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmboBxQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBxStandard;
        private System.Windows.Forms.RadioButton radBx3Day;
        private System.Windows.Forms.RadioButton radBxOvernight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxShippmentFee;
        private System.Windows.Forms.TextBox txtBxTotalPayment;
        private System.Windows.Forms.ComboBox cmboBxBags;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

