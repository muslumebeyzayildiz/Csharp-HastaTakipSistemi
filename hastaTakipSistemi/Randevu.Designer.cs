﻿namespace hastaTakipSistemi
{
    partial class Randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            this.RandevuDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SaatCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rtarih = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.RadCb = new System.Windows.Forms.ComboBox();
            this.RtedaviCb = new System.Windows.Forms.ComboBox();
            this.AraTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RandevuDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // RandevuDGV
            // 
            this.RandevuDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RandevuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandevuDGV.Location = new System.Drawing.Point(329, 197);
            this.RandevuDGV.Name = "RandevuDGV";
            this.RandevuDGV.RowHeadersWidth = 51;
            this.RandevuDGV.RowTemplate.Height = 24;
            this.RandevuDGV.Size = new System.Drawing.Size(549, 299);
            this.RandevuDGV.TabIndex = 39;
            this.RandevuDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RandevuDGV_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 80);
            this.button3.TabIndex = 38;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 80);
            this.button2.TabIndex = 37;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 80);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Poliklinik:";
            // 
            // SaatCb
            // 
            this.SaatCb.FormattingEnabled = true;
            this.SaatCb.Items.AddRange(new object[] {
            "09.00-10.00",
            "10.30-11.00",
            "11.30-12.00",
            "13.00-14.00"});
            this.SaatCb.Location = new System.Drawing.Point(148, 278);
            this.SaatCb.Name = "SaatCb";
            this.SaatCb.Size = new System.Drawing.Size(163, 24);
            this.SaatCb.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(85, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(83, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ad Soyad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAĞLIK OCAĞI HASTA TAKİP SİSTEMİ";
            // 
            // Rtarih
            // 
            this.Rtarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Rtarih.Location = new System.Drawing.Point(148, 244);
            this.Rtarih.Name = "Rtarih";
            this.Rtarih.Size = new System.Drawing.Size(163, 22);
            this.Rtarih.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 100);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 100);
            this.panel2.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(580, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 34);
            this.button7.TabIndex = 42;
            this.button7.Text = "Reçeteler";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(755, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(389, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 34);
            this.button8.TabIndex = 41;
            this.button8.Text = "Tedavi";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(578, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "SAĞLIK OCAĞI HASTA TAKİP SİSTEMİ";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Crimson;
            this.button9.Location = new System.Drawing.Point(198, 55);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 34);
            this.button9.TabIndex = 40;
            this.button9.Text = "Randevu";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Location = new System.Drawing.Point(7, 54);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 34);
            this.button10.TabIndex = 39;
            this.button10.Text = "Hasta";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // RadCb
            // 
            this.RadCb.FormattingEnabled = true;
            this.RadCb.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.RadCb.Location = new System.Drawing.Point(148, 208);
            this.RadCb.Name = "RadCb";
            this.RadCb.Size = new System.Drawing.Size(163, 24);
            this.RadCb.TabIndex = 33;
            // 
            // RtedaviCb
            // 
            this.RtedaviCb.FormattingEnabled = true;
            this.RtedaviCb.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.RtedaviCb.Location = new System.Drawing.Point(148, 314);
            this.RtedaviCb.Name = "RtedaviCb";
            this.RtedaviCb.Size = new System.Drawing.Size(163, 24);
            this.RtedaviCb.TabIndex = 43;
            // 
            // AraTb
            // 
            this.AraTb.Location = new System.Drawing.Point(389, 156);
            this.AraTb.Name = "AraTb";
            this.AraTb.Size = new System.Drawing.Size(444, 22);
            this.AraTb.TabIndex = 44;
            this.AraTb.TextChanged += new System.EventHandler(this.AraTb_TextChanged);
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 563);
            this.Controls.Add(this.AraTb);
            this.Controls.Add(this.RtedaviCb);
            this.Controls.Add(this.RandevuDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RadCb);
            this.Controls.Add(this.SaatCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rtarih);
            this.Controls.Add(this.panel1);
            this.Name = "Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RandevuDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView RandevuDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SaatCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Rtarih;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox RadCb;
        private System.Windows.Forms.ComboBox RtedaviCb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox AraTb;
    }
}