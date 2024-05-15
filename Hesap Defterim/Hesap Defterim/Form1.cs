using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Defterim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double tl = 124745.48;
        private void Form1_Load(object sender, EventArgs e)
        {
            tlLabel.Text = tl.ToString();
        }
        private double toDoble(string metin)
        {
            double sonuc = 0;
            try
            {
                sonuc = System.Convert.ToDouble(metin);
            }
            catch (Exception e)
            {
                sonuc = 0;
            }
            return sonuc;
        }

        private void tlYatirButton_Click(object sender, EventArgs e)
        {
            double deger = toDoble(tlYatirText.Text);
            tl += deger;
            tlLabel.Text = tl.ToString();
            tlYatirText.Text = "";
        }

        private void tlCekButton_Click(object sender, EventArgs e)
        {
            double deger = toDoble(tlCekText.Text);
            if (deger <= tl)
            {
                tl -= deger;
                tlLabel.Text = tl.ToString();
                tlCekText.Text = "";
            }
            else {
                MessageBox.Show("Bakiye Yetersiz");
            }
        }
    }
}
