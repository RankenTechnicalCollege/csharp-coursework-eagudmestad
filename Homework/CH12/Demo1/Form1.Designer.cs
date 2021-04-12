
namespace Demo1
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
            this.btnSellCoffee = new System.Windows.Forms.Button();
            this.lblOunces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSellCoffee
            // 
            this.btnSellCoffee.Location = new System.Drawing.Point(280, 89);
            this.btnSellCoffee.Name = "btnSellCoffee";
            this.btnSellCoffee.Size = new System.Drawing.Size(184, 74);
            this.btnSellCoffee.TabIndex = 0;
            this.btnSellCoffee.Text = "Sell Coffee Cup";
            this.btnSellCoffee.UseVisualStyleBackColor = true;
            this.btnSellCoffee.Click += new System.EventHandler(this.btnSellCoffee_Click);
            // 
            // lblOunces
            // 
            this.lblOunces.AutoSize = true;
            this.lblOunces.Location = new System.Drawing.Point(280, 222);
            this.lblOunces.Name = "lblOunces";
            this.lblOunces.Size = new System.Drawing.Size(0, 13);
            this.lblOunces.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOunces);
            this.Controls.Add(this.btnSellCoffee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSellCoffee;
        private System.Windows.Forms.Label lblOunces;
    }
}

