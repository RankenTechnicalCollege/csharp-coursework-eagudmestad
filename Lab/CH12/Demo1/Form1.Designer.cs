
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
            this.btnCreateChair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChairColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOfWheels = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateChair
            // 
            this.btnCreateChair.Location = new System.Drawing.Point(204, 121);
            this.btnCreateChair.Name = "btnCreateChair";
            this.btnCreateChair.Size = new System.Drawing.Size(183, 91);
            this.btnCreateChair.TabIndex = 0;
            this.btnCreateChair.Text = "Create Chair";
            this.btnCreateChair.UseVisualStyleBackColor = true;
            this.btnCreateChair.Click += new System.EventHandler(this.btnCreateChair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color:";
            // 
            // txtChairColor
            // 
            this.txtChairColor.Location = new System.Drawing.Point(83, 45);
            this.txtChairColor.Name = "txtChairColor";
            this.txtChairColor.Size = new System.Drawing.Size(100, 22);
            this.txtChairColor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Wheels:";
            // 
            // txtNumOfWheels
            // 
            this.txtNumOfWheels.Location = new System.Drawing.Point(424, 45);
            this.txtNumOfWheels.Name = "txtNumOfWheels";
            this.txtNumOfWheels.Size = new System.Drawing.Size(100, 22);
            this.txtNumOfWheels.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(38, 277);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNumOfWheels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChairColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateChair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateChair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChairColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumOfWheels;
        private System.Windows.Forms.Label lblResult;
    }
}

