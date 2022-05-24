
namespace ProgramiranjeDomaciIndivid
{
    partial class Login
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.imetxt = new System.Windows.Forms.TextBox();
            this.prezimetxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(180, 78);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 20);
            this.usernametxt.TabIndex = 0;
            // 
            // imetxt
            // 
            this.imetxt.Location = new System.Drawing.Point(180, 129);
            this.imetxt.Name = "imetxt";
            this.imetxt.Size = new System.Drawing.Size(100, 20);
            this.imetxt.TabIndex = 1;
            // 
            // prezimetxt
            // 
            this.prezimetxt.Location = new System.Drawing.Point(180, 179);
            this.prezimetxt.Name = "prezimetxt";
            this.prezimetxt.Size = new System.Drawing.Size(100, 20);
            this.prezimetxt.TabIndex = 2;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(180, 231);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 20);
            this.emailtxt.TabIndex = 3;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(180, 281);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 20);
            this.passtxt.TabIndex = 4;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(192, 62);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(71, 13);
            this.userlbl.TabIndex = 5;
            this.userlbl.Text = "USERNAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PREZIME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "EMAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "PASSWORD:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "REGISTRACIJA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "VEC IMAM NALOG";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.prezimetxt);
            this.Controls.Add(this.imetxt);
            this.Controls.Add(this.usernametxt);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox imetxt;
        private System.Windows.Forms.TextBox prezimetxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

