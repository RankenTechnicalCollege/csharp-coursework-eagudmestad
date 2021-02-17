
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
            this.btnKeyword = new System.Windows.Forms.Button();
            this.btnISBN = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.txtBoxKeyword = new System.Windows.Forms.TextBox();
            this.txtBoxISBN = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescip = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKeyword
            // 
            this.btnKeyword.Location = new System.Drawing.Point(313, 128);
            this.btnKeyword.Name = "btnKeyword";
            this.btnKeyword.Size = new System.Drawing.Size(75, 23);
            this.btnKeyword.TabIndex = 20;
            this.btnKeyword.Text = "Search";
            this.btnKeyword.UseVisualStyleBackColor = true;
            this.btnKeyword.Click += new System.EventHandler(this.btnKeyword_Click);
            // 
            // btnISBN
            // 
            this.btnISBN.Location = new System.Drawing.Point(313, 89);
            this.btnISBN.Name = "btnISBN";
            this.btnISBN.Size = new System.Drawing.Size(75, 23);
            this.btnISBN.TabIndex = 19;
            this.btnISBN.Text = "Search";
            this.btnISBN.UseVisualStyleBackColor = true;
            this.btnISBN.Click += new System.EventHandler(this.btnISBN_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(313, 47);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAuthor.TabIndex = 18;
            this.btnAuthor.Text = "Search";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // txtBoxKeyword
            // 
            this.txtBoxKeyword.Location = new System.Drawing.Point(102, 131);
            this.txtBoxKeyword.Name = "txtBoxKeyword";
            this.txtBoxKeyword.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKeyword.TabIndex = 17;
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(102, 92);
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxISBN.TabIndex = 16;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(102, 50);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAuthor.TabIndex = 15;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(99, 538);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 13;
            this.lblISBN.Text = "label1";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(99, 438);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(35, 13);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(73, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "ISBN-13";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(73, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Author";
            // 
            // lblDescip
            // 
            this.lblDescip.AutoSize = true;
            this.lblDescip.Location = new System.Drawing.Point(99, 340);
            this.lblDescip.Name = "lblDescip";
            this.lblDescip.Size = new System.Drawing.Size(35, 13);
            this.lblDescip.TabIndex = 9;
            this.lblDescip.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(73, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(99, 243);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(73, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Keyword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Books and Antiues";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 568);
            this.Controls.Add(this.btnKeyword);
            this.Controls.Add(this.btnISBN);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.txtBoxKeyword);
            this.Controls.Add(this.txtBoxISBN);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDescip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeyword;
        private System.Windows.Forms.Button btnISBN;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.TextBox txtBoxKeyword;
        private System.Windows.Forms.TextBox txtBoxISBN;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

