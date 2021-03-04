
namespace LB1
{
    partial class frmFoodOrder
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblNameOrFoodError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkSyrup = new System.Windows.Forms.CheckBox();
            this.lblToppingsError = new System.Windows.Forms.Label();
            this.chkLime = new System.Windows.Forms.CheckBox();
            this.chkPeach = new System.Windows.Forms.CheckBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.lblMixinError = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grpSundaeToppings = new System.Windows.Forms.GroupBox();
            this.grpDrinkMixins = new System.Windows.Forms.GroupBox();
            this.grpSundaeToppings.SuspendLayout();
            this.grpDrinkMixins.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What name do you want on the order?";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(16, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lblNameOrFoodError
            // 
            this.lblNameOrFoodError.AutoSize = true;
            this.lblNameOrFoodError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOrFoodError.ForeColor = System.Drawing.Color.Red;
            this.lblNameOrFoodError.Location = new System.Drawing.Point(13, 69);
            this.lblNameOrFoodError.Name = "lblNameOrFoodError";
            this.lblNameOrFoodError.Size = new System.Drawing.Size(253, 17);
            this.lblNameOrFoodError.TabIndex = 2;
            this.lblNameOrFoodError.Text = "Name required / No food selected";
            this.lblNameOrFoodError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do you want a sundae?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do you want a soda?";
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(16, 158);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(54, 21);
            this.chkSundae.TabIndex = 5;
            this.chkSundae.Text = "Yes";
            this.chkSundae.UseVisualStyleBackColor = true;
            this.chkSundae.CheckedChanged += new System.EventHandler(this.chkSundae_CheckedChanged);
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(207, 158);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(54, 21);
            this.chkSoda.TabIndex = 6;
            this.chkSoda.Text = "Yes";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(10, 25);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(88, 21);
            this.chkSprinkles.TabIndex = 9;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(10, 52);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(59, 21);
            this.chkNuts.TabIndex = 10;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkSyrup
            // 
            this.chkSyrup.AutoSize = true;
            this.chkSyrup.Location = new System.Drawing.Point(10, 83);
            this.chkSyrup.Name = "chkSyrup";
            this.chkSyrup.Size = new System.Drawing.Size(134, 21);
            this.chkSyrup.TabIndex = 11;
            this.chkSyrup.Text = "Chocolate Syrup";
            this.chkSyrup.UseVisualStyleBackColor = true;
            // 
            // lblToppingsError
            // 
            this.lblToppingsError.AutoSize = true;
            this.lblToppingsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsError.ForeColor = System.Drawing.Color.Red;
            this.lblToppingsError.Location = new System.Drawing.Point(8, 345);
            this.lblToppingsError.Name = "lblToppingsError";
            this.lblToppingsError.Size = new System.Drawing.Size(181, 17);
            this.lblToppingsError.TabIndex = 12;
            this.lblToppingsError.Text = "Only 2 toppings allowed";
            this.lblToppingsError.Visible = false;
            // 
            // chkLime
            // 
            this.chkLime.AutoSize = true;
            this.chkLime.Location = new System.Drawing.Point(6, 21);
            this.chkLime.Name = "chkLime";
            this.chkLime.Size = new System.Drawing.Size(103, 21);
            this.chkLime.TabIndex = 13;
            this.chkLime.Text = "Lime Flavor";
            this.chkLime.UseVisualStyleBackColor = true;
            // 
            // chkPeach
            // 
            this.chkPeach.AutoSize = true;
            this.chkPeach.Location = new System.Drawing.Point(6, 48);
            this.chkPeach.Name = "chkPeach";
            this.chkPeach.Size = new System.Drawing.Size(113, 21);
            this.chkPeach.TabIndex = 14;
            this.chkPeach.Text = "Peach Flavor";
            this.chkPeach.UseVisualStyleBackColor = true;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(6, 73);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(116, 21);
            this.chkMango.TabIndex = 15;
            this.chkMango.Text = "Mango Flavor";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // lblMixinError
            // 
            this.lblMixinError.AutoSize = true;
            this.lblMixinError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMixinError.ForeColor = System.Drawing.Color.Red;
            this.lblMixinError.Location = new System.Drawing.Point(204, 335);
            this.lblMixinError.Name = "lblMixinError";
            this.lblMixinError.Size = new System.Drawing.Size(155, 17);
            this.lblMixinError.TabIndex = 16;
            this.lblMixinError.Text = "Only 1 mixin allowed";
            this.lblMixinError.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(19, 376);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(154, 23);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add item to order";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(410, 44);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(345, 308);
            this.rtbOutput.TabIndex = 18;
            this.rtbOutput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(698, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(683, 379);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPrice.TabIndex = 21;
            // 
            // grpSundaeToppings
            // 
            this.grpSundaeToppings.Controls.Add(this.chkSprinkles);
            this.grpSundaeToppings.Controls.Add(this.chkNuts);
            this.grpSundaeToppings.Controls.Add(this.chkSyrup);
            this.grpSundaeToppings.Location = new System.Drawing.Point(1, 232);
            this.grpSundaeToppings.Name = "grpSundaeToppings";
            this.grpSundaeToppings.Size = new System.Drawing.Size(197, 110);
            this.grpSundaeToppings.TabIndex = 22;
            this.grpSundaeToppings.TabStop = false;
            this.grpSundaeToppings.Text = "Sundae Toppings";
            this.grpSundaeToppings.Visible = false;
            // 
            // grpDrinkMixins
            // 
            this.grpDrinkMixins.Controls.Add(this.chkLime);
            this.grpDrinkMixins.Controls.Add(this.chkPeach);
            this.grpDrinkMixins.Controls.Add(this.chkMango);
            this.grpDrinkMixins.Location = new System.Drawing.Point(207, 236);
            this.grpDrinkMixins.Name = "grpDrinkMixins";
            this.grpDrinkMixins.Size = new System.Drawing.Size(197, 100);
            this.grpDrinkMixins.TabIndex = 23;
            this.grpDrinkMixins.TabStop = false;
            this.grpDrinkMixins.Text = "Drink Mixins";
            this.grpDrinkMixins.Visible = false;
            // 
            // frmFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpDrinkMixins);
            this.Controls.Add(this.grpSundaeToppings);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblMixinError);
            this.Controls.Add(this.lblToppingsError);
            this.Controls.Add(this.chkSoda);
            this.Controls.Add(this.chkSundae);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameOrFoodError);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "frmFoodOrder";
            this.Text = "Food Order";
            this.grpSundaeToppings.ResumeLayout(false);
            this.grpSundaeToppings.PerformLayout();
            this.grpDrinkMixins.ResumeLayout(false);
            this.grpDrinkMixins.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblNameOrFoodError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkSyrup;
        private System.Windows.Forms.Label lblToppingsError;
        private System.Windows.Forms.CheckBox chkLime;
        private System.Windows.Forms.CheckBox chkPeach;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.Label lblMixinError;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox grpSundaeToppings;
        private System.Windows.Forms.GroupBox grpDrinkMixins;
    }
}

