
namespace LB2
{
    partial class frmInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.btnUpcSearch = new System.Windows.Forms.Button();
            this.txtUpcSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemUpc = new System.Windows.Forms.Label();
            this.lblItemStorePrice = new System.Windows.Forms.Label();
            this.lblItemCostPerCase = new System.Windows.Forms.Label();
            this.lblItemUnitsPerCase = new System.Windows.Forms.Label();
            this.lblItemDistributor = new System.Windows.Forms.Label();
            this.grpUpdateItem = new System.Windows.Forms.GroupBox();
            this.grpDeleteItem = new System.Windows.Forms.GroupBox();
            this.grpAddItem = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateAccessKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeleteItemUpc = new System.Windows.Forms.TextBox();
            this.txtDeleteItemAccessKey = new System.Windows.Forms.TextBox();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.lblUpdateError = new System.Windows.Forms.Label();
            this.lblDeleteError = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblAddError = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddUpc = new System.Windows.Forms.TextBox();
            this.txtAddStorePrice = new System.Windows.Forms.TextBox();
            this.txtAddAccessKey = new System.Windows.Forms.TextBox();
            this.txtAddCostPerCase = new System.Windows.Forms.TextBox();
            this.txtAddUnitsPerCase = new System.Windows.Forms.TextBox();
            this.txtAddDistributor = new System.Windows.Forms.TextBox();
            this.grpUpdateItem.SuspendLayout();
            this.grpDeleteItem.SuspendLayout();
            this.grpAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Name";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(29, 60);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtNameSearch.TabIndex = 1;
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Location = new System.Drawing.Point(156, 58);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(75, 23);
            this.btnNameSearch.TabIndex = 2;
            this.btnNameSearch.Text = "Search";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // btnUpcSearch
            // 
            this.btnUpcSearch.Location = new System.Drawing.Point(420, 58);
            this.btnUpcSearch.Name = "btnUpcSearch";
            this.btnUpcSearch.Size = new System.Drawing.Size(75, 23);
            this.btnUpcSearch.TabIndex = 5;
            this.btnUpcSearch.Text = "Search";
            this.btnUpcSearch.UseVisualStyleBackColor = true;
            this.btnUpcSearch.Click += new System.EventHandler(this.btnUpcSearch_Click);
            // 
            // txtUpcSearch
            // 
            this.txtUpcSearch.Location = new System.Drawing.Point(293, 60);
            this.txtUpcSearch.Name = "txtUpcSearch";
            this.txtUpcSearch.Size = new System.Drawing.Size(100, 20);
            this.txtUpcSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by UPC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "UPC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Store Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cost Per Case:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Units Per Case:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Distributor:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(77, 109);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(0, 13);
            this.lblItemName.TabIndex = 12;
            // 
            // lblItemUpc
            // 
            this.lblItemUpc.AutoSize = true;
            this.lblItemUpc.Location = new System.Drawing.Point(71, 141);
            this.lblItemUpc.Name = "lblItemUpc";
            this.lblItemUpc.Size = new System.Drawing.Size(0, 13);
            this.lblItemUpc.TabIndex = 13;
            // 
            // lblItemStorePrice
            // 
            this.lblItemStorePrice.AutoSize = true;
            this.lblItemStorePrice.Location = new System.Drawing.Point(101, 167);
            this.lblItemStorePrice.Name = "lblItemStorePrice";
            this.lblItemStorePrice.Size = new System.Drawing.Size(0, 13);
            this.lblItemStorePrice.TabIndex = 14;
            // 
            // lblItemCostPerCase
            // 
            this.lblItemCostPerCase.AutoSize = true;
            this.lblItemCostPerCase.Location = new System.Drawing.Point(377, 108);
            this.lblItemCostPerCase.Name = "lblItemCostPerCase";
            this.lblItemCostPerCase.Size = new System.Drawing.Size(0, 13);
            this.lblItemCostPerCase.TabIndex = 15;
            // 
            // lblItemUnitsPerCase
            // 
            this.lblItemUnitsPerCase.AutoSize = true;
            this.lblItemUnitsPerCase.Location = new System.Drawing.Point(380, 140);
            this.lblItemUnitsPerCase.Name = "lblItemUnitsPerCase";
            this.lblItemUnitsPerCase.Size = new System.Drawing.Size(0, 13);
            this.lblItemUnitsPerCase.TabIndex = 16;
            // 
            // lblItemDistributor
            // 
            this.lblItemDistributor.AutoSize = true;
            this.lblItemDistributor.Location = new System.Drawing.Point(357, 167);
            this.lblItemDistributor.Name = "lblItemDistributor";
            this.lblItemDistributor.Size = new System.Drawing.Size(0, 13);
            this.lblItemDistributor.TabIndex = 17;
            // 
            // grpUpdateItem
            // 
            this.grpUpdateItem.Controls.Add(this.lblUpdateError);
            this.grpUpdateItem.Controls.Add(this.btnUpdatePrice);
            this.grpUpdateItem.Controls.Add(this.txtUpdateAccessKey);
            this.grpUpdateItem.Controls.Add(this.txtUpdatePrice);
            this.grpUpdateItem.Controls.Add(this.label11);
            this.grpUpdateItem.Controls.Add(this.label10);
            this.grpUpdateItem.Controls.Add(this.label9);
            this.grpUpdateItem.Location = new System.Drawing.Point(35, 232);
            this.grpUpdateItem.Name = "grpUpdateItem";
            this.grpUpdateItem.Size = new System.Drawing.Size(205, 159);
            this.grpUpdateItem.TabIndex = 18;
            this.grpUpdateItem.TabStop = false;
            this.grpUpdateItem.Text = "Update Item";
            this.grpUpdateItem.Visible = false;
            // 
            // grpDeleteItem
            // 
            this.grpDeleteItem.Controls.Add(this.btnDeleteItem);
            this.grpDeleteItem.Controls.Add(this.lblDeleteError);
            this.grpDeleteItem.Controls.Add(this.txtDeleteItemAccessKey);
            this.grpDeleteItem.Controls.Add(this.txtDeleteItemUpc);
            this.grpDeleteItem.Controls.Add(this.label14);
            this.grpDeleteItem.Controls.Add(this.label13);
            this.grpDeleteItem.Controls.Add(this.label12);
            this.grpDeleteItem.Location = new System.Drawing.Point(324, 232);
            this.grpDeleteItem.Name = "grpDeleteItem";
            this.grpDeleteItem.Size = new System.Drawing.Size(247, 159);
            this.grpDeleteItem.TabIndex = 19;
            this.grpDeleteItem.TabStop = false;
            this.grpDeleteItem.Text = "Delete Item";
            this.grpDeleteItem.Visible = false;
            // 
            // grpAddItem
            // 
            this.grpAddItem.Controls.Add(this.txtAddDistributor);
            this.grpAddItem.Controls.Add(this.txtAddUnitsPerCase);
            this.grpAddItem.Controls.Add(this.txtAddCostPerCase);
            this.grpAddItem.Controls.Add(this.txtAddAccessKey);
            this.grpAddItem.Controls.Add(this.txtAddStorePrice);
            this.grpAddItem.Controls.Add(this.txtAddUpc);
            this.grpAddItem.Controls.Add(this.txtAddName);
            this.grpAddItem.Controls.Add(this.lblAddError);
            this.grpAddItem.Controls.Add(this.btnAddItem);
            this.grpAddItem.Controls.Add(this.label22);
            this.grpAddItem.Controls.Add(this.label21);
            this.grpAddItem.Controls.Add(this.label20);
            this.grpAddItem.Controls.Add(this.label19);
            this.grpAddItem.Controls.Add(this.label18);
            this.grpAddItem.Controls.Add(this.label17);
            this.grpAddItem.Controls.Add(this.label16);
            this.grpAddItem.Controls.Add(this.label15);
            this.grpAddItem.Location = new System.Drawing.Point(35, 416);
            this.grpAddItem.Name = "grpAddItem";
            this.grpAddItem.Size = new System.Drawing.Size(489, 207);
            this.grpAddItem.TabIndex = 20;
            this.grpAddItem.TabStop = false;
            this.grpAddItem.Text = "Add Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Change Store Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "New Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Access Key";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(80, 38);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePrice.TabIndex = 3;
            // 
            // txtUpdateAccessKey
            // 
            this.txtUpdateAccessKey.Location = new System.Drawing.Point(80, 74);
            this.txtUpdateAccessKey.Name = "txtUpdateAccessKey";
            this.txtUpdateAccessKey.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateAccessKey.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Delete Item";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Verify UPC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Access Key";
            // 
            // txtDeleteItemUpc
            // 
            this.txtDeleteItemUpc.Location = new System.Drawing.Point(77, 38);
            this.txtDeleteItemUpc.Name = "txtDeleteItemUpc";
            this.txtDeleteItemUpc.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteItemUpc.TabIndex = 3;
            // 
            // txtDeleteItemAccessKey
            // 
            this.txtDeleteItemAccessKey.Location = new System.Drawing.Point(76, 74);
            this.txtDeleteItemAccessKey.Name = "txtDeleteItemAccessKey";
            this.txtDeleteItemAccessKey.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteItemAccessKey.TabIndex = 4;
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(45, 103);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(99, 23);
            this.btnUpdatePrice.TabIndex = 5;
            this.btnUpdatePrice.Text = "Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // lblUpdateError
            // 
            this.lblUpdateError.AutoSize = true;
            this.lblUpdateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateError.ForeColor = System.Drawing.Color.Red;
            this.lblUpdateError.Location = new System.Drawing.Point(18, 129);
            this.lblUpdateError.Name = "lblUpdateError";
            this.lblUpdateError.Size = new System.Drawing.Size(178, 20);
            this.lblUpdateError.TabIndex = 6;
            this.lblUpdateError.Text = "Access Key Incorrect";
            this.lblUpdateError.Visible = false;
            // 
            // lblDeleteError
            // 
            this.lblDeleteError.AutoSize = true;
            this.lblDeleteError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteError.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteError.Location = new System.Drawing.Point(6, 129);
            this.lblDeleteError.Name = "lblDeleteError";
            this.lblDeleteError.Size = new System.Drawing.Size(240, 20);
            this.lblDeleteError.TabIndex = 21;
            this.lblDeleteError.Text = "Access Key or UPC Incorrect";
            this.lblDeleteError.Visible = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(36, 103);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteItem.TabIndex = 22;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Add New Item";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Upc";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Store Price";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Access Key";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(241, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Cost Per Case";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(241, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Units Per Case";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(241, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Distributor";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(240, 146);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblAddError
            // 
            this.lblAddError.AutoSize = true;
            this.lblAddError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddError.ForeColor = System.Drawing.Color.Red;
            this.lblAddError.Location = new System.Drawing.Point(18, 184);
            this.lblAddError.Name = "lblAddError";
            this.lblAddError.Size = new System.Drawing.Size(178, 20);
            this.lblAddError.TabIndex = 9;
            this.lblAddError.Text = "Access Key Incorrect";
            this.lblAddError.Visible = false;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(80, 50);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 10;
            // 
            // txtAddUpc
            // 
            this.txtAddUpc.Location = new System.Drawing.Point(80, 81);
            this.txtAddUpc.Name = "txtAddUpc";
            this.txtAddUpc.Size = new System.Drawing.Size(100, 20);
            this.txtAddUpc.TabIndex = 11;
            // 
            // txtAddStorePrice
            // 
            this.txtAddStorePrice.Location = new System.Drawing.Point(80, 118);
            this.txtAddStorePrice.Name = "txtAddStorePrice";
            this.txtAddStorePrice.Size = new System.Drawing.Size(100, 20);
            this.txtAddStorePrice.TabIndex = 12;
            // 
            // txtAddAccessKey
            // 
            this.txtAddAccessKey.Location = new System.Drawing.Point(80, 148);
            this.txtAddAccessKey.Name = "txtAddAccessKey";
            this.txtAddAccessKey.Size = new System.Drawing.Size(100, 20);
            this.txtAddAccessKey.TabIndex = 13;
            // 
            // txtAddCostPerCase
            // 
            this.txtAddCostPerCase.Location = new System.Drawing.Point(321, 50);
            this.txtAddCostPerCase.Name = "txtAddCostPerCase";
            this.txtAddCostPerCase.Size = new System.Drawing.Size(100, 20);
            this.txtAddCostPerCase.TabIndex = 14;
            // 
            // txtAddUnitsPerCase
            // 
            this.txtAddUnitsPerCase.Location = new System.Drawing.Point(321, 81);
            this.txtAddUnitsPerCase.Name = "txtAddUnitsPerCase";
            this.txtAddUnitsPerCase.Size = new System.Drawing.Size(100, 20);
            this.txtAddUnitsPerCase.TabIndex = 15;
            // 
            // txtAddDistributor
            // 
            this.txtAddDistributor.Location = new System.Drawing.Point(321, 118);
            this.txtAddDistributor.Name = "txtAddDistributor";
            this.txtAddDistributor.Size = new System.Drawing.Size(100, 20);
            this.txtAddDistributor.TabIndex = 16;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 644);
            this.Controls.Add(this.grpAddItem);
            this.Controls.Add(this.grpDeleteItem);
            this.Controls.Add(this.grpUpdateItem);
            this.Controls.Add(this.lblItemDistributor);
            this.Controls.Add(this.lblItemUnitsPerCase);
            this.Controls.Add(this.lblItemCostPerCase);
            this.Controls.Add(this.lblItemStorePrice);
            this.Controls.Add(this.lblItemUpc);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpcSearch);
            this.Controls.Add(this.txtUpcSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNameSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmInventory";
            this.Text = "Store Inventory & Price Inquiry";
            this.grpUpdateItem.ResumeLayout(false);
            this.grpUpdateItem.PerformLayout();
            this.grpDeleteItem.ResumeLayout(false);
            this.grpDeleteItem.PerformLayout();
            this.grpAddItem.ResumeLayout(false);
            this.grpAddItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Button btnUpcSearch;
        private System.Windows.Forms.TextBox txtUpcSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemUpc;
        private System.Windows.Forms.Label lblItemStorePrice;
        private System.Windows.Forms.Label lblItemCostPerCase;
        private System.Windows.Forms.Label lblItemUnitsPerCase;
        private System.Windows.Forms.Label lblItemDistributor;
        private System.Windows.Forms.GroupBox grpUpdateItem;
        private System.Windows.Forms.GroupBox grpDeleteItem;
        private System.Windows.Forms.GroupBox grpAddItem;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateAccessKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDeleteItemAccessKey;
        private System.Windows.Forms.TextBox txtDeleteItemUpc;
        private System.Windows.Forms.Label lblUpdateError;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Label lblDeleteError;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblAddError;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddAccessKey;
        private System.Windows.Forms.TextBox txtAddStorePrice;
        private System.Windows.Forms.TextBox txtAddUpc;
        private System.Windows.Forms.TextBox txtAddCostPerCase;
        private System.Windows.Forms.TextBox txtAddDistributor;
        private System.Windows.Forms.TextBox txtAddUnitsPerCase;
    }
}

