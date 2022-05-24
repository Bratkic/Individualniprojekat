
namespace ProgramiranjeDomaciIndivid
{
    partial class Album
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Godine = new System.Windows.Forms.ComboBox();
            this.Izdavaci = new System.Windows.Forms.ComboBox();
            this.nazivAlbuma = new System.Windows.Forms.TextBox();
            this.Dodaj_Album = new System.Windows.Forms.Button();
            this.godtxt = new System.Windows.Forms.TextBox();
            this.izdavactxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Godine
            // 
            this.Godine.FormattingEnabled = true;
            this.Godine.Location = new System.Drawing.Point(41, 219);
            this.Godine.Name = "Godine";
            this.Godine.Size = new System.Drawing.Size(121, 21);
            this.Godine.TabIndex = 1;
            // 
            // Izdavaci
            // 
            this.Izdavaci.FormattingEnabled = true;
            this.Izdavaci.Location = new System.Drawing.Point(189, 218);
            this.Izdavaci.Name = "Izdavaci";
            this.Izdavaci.Size = new System.Drawing.Size(121, 21);
            this.Izdavaci.TabIndex = 2;
            // 
            // nazivAlbuma
            // 
            this.nazivAlbuma.Location = new System.Drawing.Point(349, 219);
            this.nazivAlbuma.Name = "nazivAlbuma";
            this.nazivAlbuma.Size = new System.Drawing.Size(100, 20);
            this.nazivAlbuma.TabIndex = 3;
            // 
            // Dodaj_Album
            // 
            this.Dodaj_Album.Location = new System.Drawing.Point(497, 216);
            this.Dodaj_Album.Name = "Dodaj_Album";
            this.Dodaj_Album.Size = new System.Drawing.Size(112, 23);
            this.Dodaj_Album.TabIndex = 4;
            this.Dodaj_Album.Text = "DODAJ ALBUM";
            this.Dodaj_Album.UseVisualStyleBackColor = true;
            this.Dodaj_Album.Click += new System.EventHandler(this.Dodaj_Album_Click_1);
            // 
            // godtxt
            // 
            this.godtxt.Location = new System.Drawing.Point(41, 322);
            this.godtxt.Name = "godtxt";
            this.godtxt.Size = new System.Drawing.Size(100, 20);
            this.godtxt.TabIndex = 5;
            // 
            // izdavactxt
            // 
            this.izdavactxt.Location = new System.Drawing.Point(189, 321);
            this.izdavactxt.Name = "izdavactxt";
            this.izdavactxt.Size = new System.Drawing.Size(100, 20);
            this.izdavactxt.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.izdavactxt);
            this.Controls.Add(this.godtxt);
            this.Controls.Add(this.Dodaj_Album);
            this.Controls.Add(this.nazivAlbuma);
            this.Controls.Add(this.Izdavaci);
            this.Controls.Add(this.Godine);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Album";
            this.Text = "Album";
            this.Load += new System.EventHandler(this.Album_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Godine;
        private System.Windows.Forms.ComboBox Izdavaci;
        private System.Windows.Forms.TextBox nazivAlbuma;
        private System.Windows.Forms.Button Dodaj_Album;
        private System.Windows.Forms.TextBox godtxt;
        private System.Windows.Forms.TextBox izdavactxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}