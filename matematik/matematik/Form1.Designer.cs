namespace matematik
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
            this.alanLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genislik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yukseklik = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alanLabel
            // 
            this.alanLabel.AutoSize = true;
            this.alanLabel.Location = new System.Drawing.Point(68, 36);
            this.alanLabel.Name = "alanLabel";
            this.alanLabel.Size = new System.Drawing.Size(127, 13);
            this.alanLabel.TabIndex = 0;
            this.alanLabel.Text = "Dikdörtgenin Alan Hesabı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genişlik";
            // 
            // genislik
            // 
            this.genislik.Location = new System.Drawing.Point(118, 68);
            this.genislik.Name = "genislik";
            this.genislik.Size = new System.Drawing.Size(100, 20);
            this.genislik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yükseklik";
            // 
            // yukseklik
            // 
            this.yukseklik.Location = new System.Drawing.Point(118, 105);
            this.yukseklik.Name = "yukseklik";
            this.yukseklik.Size = new System.Drawing.Size(100, 20);
            this.yukseklik.TabIndex = 4;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(104, 140);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 23);
            this.hesapla.TabIndex = 5;
            this.hesapla.Text = "HESAPLA";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 368);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.yukseklik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genislik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alanLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alanLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox genislik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yukseklik;
        private System.Windows.Forms.Button hesapla;
    }
}

