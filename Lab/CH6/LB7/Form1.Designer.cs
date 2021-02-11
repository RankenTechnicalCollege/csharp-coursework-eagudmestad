
namespace LB7
{
    partial class frmCreditCardMasker
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
            this.lblMasked = new System.Windows.Forms.Label();
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.btnMask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMasked
            // 
            this.lblMasked.AutoSize = true;
            this.lblMasked.Location = new System.Drawing.Point(53, 98);
            this.lblMasked.Name = "lblMasked";
            this.lblMasked.Size = new System.Drawing.Size(0, 13);
            this.lblMasked.TabIndex = 0;
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Location = new System.Drawing.Point(56, 51);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(275, 20);
            this.txtCCNumber.TabIndex = 1;
            // 
            // btnMask
            // 
            this.btnMask.Location = new System.Drawing.Point(397, 51);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(75, 23);
            this.btnMask.TabIndex = 2;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // frmCreditCardMasker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 208);
            this.Controls.Add(this.btnMask);
            this.Controls.Add(this.txtCCNumber);
            this.Controls.Add(this.lblMasked);
            this.Name = "frmCreditCardMasker";
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasked;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.Button btnMask;
    }
}

