namespace carPrice
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.TextBox();
            this.carModelValue = new System.Windows.Forms.TextBox();
            this.carKMValue = new System.Windows.Forms.TextBox();
            this.carDamage = new System.Windows.Forms.TextBox();
            this.carDamegePercent = new System.Windows.Forms.TextBox();
            this.carMaxPrice = new System.Windows.Forms.TextBox();
            this.carEstimatedValue = new System.Windows.Forms.TextBox();
            this.carPertPercent = new System.Windows.Forms.TextBox();
            this.carPertValue = new System.Windows.Forms.TextBox();
            this.carDemageValue = new System.Windows.Forms.TextBox();
            this.carKM = new System.Windows.Forms.TextBox();
            this.carModelPercent = new System.Windows.Forms.TextBox();
            this.carModel = new System.Windows.Forms.TextBox();
            this.carCalculate = new System.Windows.Forms.Button();
            this.carPertYes = new System.Windows.Forms.RadioButton();
            this.carPertNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tahmini Piyasa Değeri  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maksimum Fiyat  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pert Kaydı  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hasar Kaydı  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "%/1.000.000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kilometre  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Model Yılı  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Araç Tanımı  :";
            // 
            // carName
            // 
            this.carName.Location = new System.Drawing.Point(121, 30);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(329, 20);
            this.carName.TabIndex = 13;
            // 
            // carModelValue
            // 
            this.carModelValue.Location = new System.Drawing.Point(350, 61);
            this.carModelValue.Name = "carModelValue";
            this.carModelValue.Size = new System.Drawing.Size(100, 20);
            this.carModelValue.TabIndex = 14;
            // 
            // carKMValue
            // 
            this.carKMValue.Location = new System.Drawing.Point(350, 109);
            this.carKMValue.Name = "carKMValue";
            this.carKMValue.Size = new System.Drawing.Size(100, 20);
            this.carKMValue.TabIndex = 15;
            // 
            // carDamage
            // 
            this.carDamage.Location = new System.Drawing.Point(121, 152);
            this.carDamage.Name = "carDamage";
            this.carDamage.Size = new System.Drawing.Size(100, 20);
            this.carDamage.TabIndex = 16;
            // 
            // carDamegePercent
            // 
            this.carDamegePercent.Location = new System.Drawing.Point(248, 152);
            this.carDamegePercent.Name = "carDamegePercent";
            this.carDamegePercent.Size = new System.Drawing.Size(33, 20);
            this.carDamegePercent.TabIndex = 17;
            // 
            // carMaxPrice
            // 
            this.carMaxPrice.Location = new System.Drawing.Point(153, 226);
            this.carMaxPrice.Name = "carMaxPrice";
            this.carMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.carMaxPrice.TabIndex = 18;
            // 
            // carEstimatedValue
            // 
            this.carEstimatedValue.Location = new System.Drawing.Point(255, 281);
            this.carEstimatedValue.Name = "carEstimatedValue";
            this.carEstimatedValue.Size = new System.Drawing.Size(100, 20);
            this.carEstimatedValue.TabIndex = 19;
            // 
            // carPertPercent
            // 
            this.carPertPercent.Location = new System.Drawing.Point(248, 184);
            this.carPertPercent.Name = "carPertPercent";
            this.carPertPercent.Size = new System.Drawing.Size(33, 20);
            this.carPertPercent.TabIndex = 20;
            // 
            // carPertValue
            // 
            this.carPertValue.Location = new System.Drawing.Point(350, 184);
            this.carPertValue.Name = "carPertValue";
            this.carPertValue.Size = new System.Drawing.Size(100, 20);
            this.carPertValue.TabIndex = 21;
            // 
            // carDemageValue
            // 
            this.carDemageValue.Location = new System.Drawing.Point(350, 152);
            this.carDemageValue.Name = "carDemageValue";
            this.carDemageValue.Size = new System.Drawing.Size(100, 20);
            this.carDemageValue.TabIndex = 22;
            // 
            // carKM
            // 
            this.carKM.Location = new System.Drawing.Point(121, 109);
            this.carKM.Name = "carKM";
            this.carKM.Size = new System.Drawing.Size(69, 20);
            this.carKM.TabIndex = 23;
            // 
            // carModelPercent
            // 
            this.carModelPercent.Location = new System.Drawing.Point(227, 61);
            this.carModelPercent.Name = "carModelPercent";
            this.carModelPercent.Size = new System.Drawing.Size(54, 20);
            this.carModelPercent.TabIndex = 24;
            // 
            // carModel
            // 
            this.carModel.Location = new System.Drawing.Point(121, 61);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(64, 20);
            this.carModel.TabIndex = 25;
            // 
            // carCalculate
            // 
            this.carCalculate.Location = new System.Drawing.Point(307, 224);
            this.carCalculate.Name = "carCalculate";
            this.carCalculate.Size = new System.Drawing.Size(75, 23);
            this.carCalculate.TabIndex = 26;
            this.carCalculate.Text = "HESAPLA";
            this.carCalculate.UseVisualStyleBackColor = true;
            this.carCalculate.Click += new System.EventHandler(this.carCalculate_Click);
            // 
            // carPertYes
            // 
            this.carPertYes.AutoSize = true;
            this.carPertYes.Location = new System.Drawing.Point(121, 185);
            this.carPertYes.Name = "carPertYes";
            this.carPertYes.Size = new System.Drawing.Size(47, 17);
            this.carPertYes.TabIndex = 27;
            this.carPertYes.TabStop = true;
            this.carPertYes.Text = "Evet";
            this.carPertYes.UseVisualStyleBackColor = true;
            // 
            // carPertNo
            // 
            this.carPertNo.AutoSize = true;
            this.carPertNo.Location = new System.Drawing.Point(164, 185);
            this.carPertNo.Name = "carPertNo";
            this.carPertNo.Size = new System.Drawing.Size(49, 17);
            this.carPertNo.TabIndex = 28;
            this.carPertNo.TabStop = true;
            this.carPertNo.Text = "Hayır";
            this.carPertNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 378);
            this.Controls.Add(this.carPertNo);
            this.Controls.Add(this.carPertYes);
            this.Controls.Add(this.carCalculate);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carModelPercent);
            this.Controls.Add(this.carKM);
            this.Controls.Add(this.carDemageValue);
            this.Controls.Add(this.carPertValue);
            this.Controls.Add(this.carPertPercent);
            this.Controls.Add(this.carEstimatedValue);
            this.Controls.Add(this.carMaxPrice);
            this.Controls.Add(this.carDamegePercent);
            this.Controls.Add(this.carDamage);
            this.Controls.Add(this.carKMValue);
            this.Controls.Add(this.carModelValue);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox carName;
        private System.Windows.Forms.TextBox carModelValue;
        private System.Windows.Forms.TextBox carKMValue;
        private System.Windows.Forms.TextBox carDamage;
        private System.Windows.Forms.TextBox carDamegePercent;
        private System.Windows.Forms.TextBox carMaxPrice;
        private System.Windows.Forms.TextBox carEstimatedValue;
        private System.Windows.Forms.TextBox carPertPercent;
        private System.Windows.Forms.TextBox carPertValue;
        private System.Windows.Forms.TextBox carDemageValue;
        private System.Windows.Forms.TextBox carKM;
        private System.Windows.Forms.TextBox carModelPercent;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.Button carCalculate;
        private System.Windows.Forms.RadioButton carPertYes;
        private System.Windows.Forms.RadioButton carPertNo;
    }
}

