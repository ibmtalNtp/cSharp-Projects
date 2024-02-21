using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba CSharp");
            Font f1 = new Font("arial",12);
            this.Width = 1000;
            this.Height = 600;
            TextBox metin = new TextBox();
            Label adLabel = new Label();
            TextBox adText = new TextBox();
            Label soyadLabel = new Label();
            Label talepLabel = new Label();
            RichTextBox talepRichText = new RichTextBox();

            this.Controls.Add(metin);
            metin.Left = 200;

            this.Controls.Add(adLabel);
            adLabel.Text = "Adınız";
            adLabel.Left = 50;
            adLabel.Top = 50;
            adLabel.ForeColor = Color.Green;
            adLabel.Font = f1;
            

            //Soyad E-Posta Adres Telefon
            this.Controls.Add(adText);
            adText.Left = 160;
            adText.Top = 50;

            this.Controls.Add(soyadLabel);
            soyadLabel.Text = "Soyadınız";

            this.Controls.Add(talepLabel);
            talepLabel.Text = "Talep ve İstekleriniz";
            talepLabel.Left = 500;
            talepLabel.Top = 100;
            talepLabel.Width = 400;

            this.Controls.Add(talepRichText);
            talepRichText.Left = 500;
            talepRichText.Top = 125;
            talepRichText.Width = 400;
            talepRichText.Height = 400;
            talepRichText.BackColor = Color.FromArgb(203,198,27);
        }
    }
}
