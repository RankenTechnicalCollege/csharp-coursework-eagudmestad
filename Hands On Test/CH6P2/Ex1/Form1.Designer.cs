
namespace Ex1
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
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblLargeCart = new System.Windows.Forms.Label();
            this.lblMediumCart = new System.Windows.Forms.Label();
            this.lblSmallCart = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblSmall = new System.Windows.Forms.Label();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(151, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 39);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear Order";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.lblLargeCart);
            this.groupBox1.Controls.Add(this.lblMediumCart);
            this.groupBox1.Controls.Add(this.lblSmallCart);
            this.groupBox1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 294);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Cart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "-—-—-—-—-—-—-—-—-—-—-—-—-—";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(6, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(93, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$--.--";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTax.Location = new System.Drawing.Point(93, 222);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(49, 24);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "$--.--";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Location = new System.Drawing.Point(93, 188);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 24);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "$--.--";
            // 
            // lblLargeCart
            // 
            this.lblLargeCart.AutoSize = true;
            this.lblLargeCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeCart.Location = new System.Drawing.Point(6, 115);
            this.lblLargeCart.Name = "lblLargeCart";
            this.lblLargeCart.Size = new System.Drawing.Size(58, 24);
            this.lblLargeCart.TabIndex = 2;
            this.lblLargeCart.Text = "label5";
            // 
            // lblMediumCart
            // 
            this.lblMediumCart.AutoSize = true;
            this.lblMediumCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMediumCart.Location = new System.Drawing.Point(6, 76);
            this.lblMediumCart.Name = "lblMediumCart";
            this.lblMediumCart.Size = new System.Drawing.Size(58, 24);
            this.lblMediumCart.TabIndex = 1;
            this.lblMediumCart.Text = "label5";
            // 
            // lblSmallCart
            // 
            this.lblSmallCart.AutoSize = true;
            this.lblSmallCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallCart.Location = new System.Drawing.Point(6, 36);
            this.lblSmallCart.Name = "lblSmallCart";
            this.lblSmallCart.Size = new System.Drawing.Size(194, 24);
            this.lblSmallCart.TabIndex = 0;
            this.lblSmallCart.Text = "2 Small @ $9.99 each";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(283, 90);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(16, 24);
            this.lblLarge.TabIndex = 21;
            this.lblLarge.Text = "-";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(212, 90);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(16, 24);
            this.lblMedium.TabIndex = 20;
            this.lblMedium.Text = "-";
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmall.Location = new System.Drawing.Point(145, 90);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(16, 24);
            this.lblSmall.TabIndex = 19;
            this.lblSmall.Text = "-";
            // 
            // btnLarge
            // 
            this.btnLarge.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLarge.Location = new System.Drawing.Point(271, 47);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(40, 40);
            this.btnLarge.TabIndex = 18;
            this.btnLarge.Text = "L";
            this.btnLarge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(200, 47);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(40, 40);
            this.btnMedium.TabIndex = 17;
            this.btnMedium.Text = "M";
            this.btnMedium.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmall.Location = new System.Drawing.Point(134, 47);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(40, 40);
            this.btnSmall.TabIndex = 16;
            this.btnSmall.Text = "S";
            this.btnSmall.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "$11.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "$10.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "$9.99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, -49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "What size shirts do you need?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 559);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblSmall);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblLargeCart;
        private System.Windows.Forms.Label lblMediumCart;
        private System.Windows.Forms.Label lblSmallCart;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

