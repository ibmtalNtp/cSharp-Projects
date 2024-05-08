namespace insaatmaliyet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cimentoBirimFiyat = new System.Windows.Forms.TextBox();
            this.cimentoMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cimentoTutar = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.demirBirimFiyat = new System.Windows.Forms.TextBox();
            this.demirMiktar = new System.Windows.Forms.TextBox();
            this.demirTutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tutar(TL)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çimento";
            // 
            // cimentoBirimFiyat
            // 
            this.cimentoBirimFiyat.Location = new System.Drawing.Point(134, 57);
            this.cimentoBirimFiyat.Name = "cimentoBirimFiyat";
            this.cimentoBirimFiyat.Size = new System.Drawing.Size(77, 20);
            this.cimentoBirimFiyat.TabIndex = 5;
            // 
            // cimentoMiktar
            // 
            this.cimentoMiktar.Location = new System.Drawing.Point(234, 57);
            this.cimentoMiktar.Name = "cimentoMiktar";
            this.cimentoMiktar.Size = new System.Drawing.Size(61, 20);
            this.cimentoMiktar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "KG";
            // 
            // cimentoTutar
            // 
            this.cimentoTutar.Location = new System.Drawing.Point(338, 57);
            this.cimentoTutar.Name = "cimentoTutar";
            this.cimentoTutar.Size = new System.Drawing.Size(66, 20);
            this.cimentoTutar.TabIndex = 8;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(448, 29);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(172, 58);
            this.hesapla.TabIndex = 9;
            this.hesapla.Text = "HESAPLA";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Demir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Beton";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kereste";
            // 
            // demirBirimFiyat
            // 
            this.demirBirimFiyat.Location = new System.Drawing.Point(134, 90);
            this.demirBirimFiyat.Name = "demirBirimFiyat";
            this.demirBirimFiyat.Size = new System.Drawing.Size(77, 20);
            this.demirBirimFiyat.TabIndex = 11;
            // 
            // demirMiktar
            // 
            this.demirMiktar.Location = new System.Drawing.Point(234, 90);
            this.demirMiktar.Name = "demirMiktar";
            this.demirMiktar.Size = new System.Drawing.Size(61, 20);
            this.demirMiktar.TabIndex = 12;
            // 
            // demirTutar
            // 
            this.demirTutar.Location = new System.Drawing.Point(338, 90);
            this.demirTutar.Name = "demirTutar";
            this.demirTutar.Size = new System.Drawing.Size(66, 20);
            this.demirTutar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 355);
            this.Controls.Add(this.demirTutar);
            this.Controls.Add(this.demirMiktar);
            this.Controls.Add(this.demirBirimFiyat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.cimentoTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cimentoMiktar);
            this.Controls.Add(this.cimentoBirimFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cimentoBirimFiyat;
        private System.Windows.Forms.TextBox cimentoMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cimentoTutar;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox demirBirimFiyat;
        private System.Windows.Forms.TextBox demirMiktar;
        private System.Windows.Forms.TextBox demirTutar;
    }
}

