
namespace LB8
{
    partial class frmCustomDesk
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtWoodType = new System.Windows.Forms.TextBox();
            this.txtNumDrawers = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWoodCost = new System.Windows.Forms.Label();
            this.lblDrawerCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Wood";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Drawers";
            // 
            // txtWoodType
            // 
            this.txtWoodType.Location = new System.Drawing.Point(42, 76);
            this.txtWoodType.Name = "txtWoodType";
            this.txtWoodType.Size = new System.Drawing.Size(100, 20);
            this.txtWoodType.TabIndex = 2;
            // 
            // txtNumDrawers
            // 
            this.txtNumDrawers.Location = new System.Drawing.Point(251, 76);
            this.txtNumDrawers.Name = "txtNumDrawers";
            this.txtNumDrawers.Size = new System.Drawing.Size(100, 20);
            this.txtNumDrawers.TabIndex = 3;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(42, 133);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(87, 33);
            this.btnEstimate.TabIndex = 4;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost of Wood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Cost";
            // 
            // lblWoodCost
            // 
            this.lblWoodCost.AutoSize = true;
            this.lblWoodCost.Location = new System.Drawing.Point(45, 259);
            this.lblWoodCost.Name = "lblWoodCost";
            this.lblWoodCost.Size = new System.Drawing.Size(0, 13);
            this.lblWoodCost.TabIndex = 8;
            // 
            // lblDrawerCost
            // 
            this.lblDrawerCost.AutoSize = true;
            this.lblDrawerCost.Location = new System.Drawing.Point(237, 258);
            this.lblDrawerCost.Name = "lblDrawerCost";
            this.lblDrawerCost.Size = new System.Drawing.Size(0, 13);
            this.lblDrawerCost.TabIndex = 9;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(452, 257);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCost.TabIndex = 10;
            // 
            // frmCustomDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblDrawerCost);
            this.Controls.Add(this.lblWoodCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.txtNumDrawers);
            this.Controls.Add(this.txtWoodType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomDesk";
            this.Text = "My Custom Desk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWoodType;
        private System.Windows.Forms.TextBox txtNumDrawers;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWoodCost;
        private System.Windows.Forms.Label lblDrawerCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

