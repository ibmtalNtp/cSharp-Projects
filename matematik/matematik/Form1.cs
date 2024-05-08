using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            int a=0;
            try {
                a = System.Convert.ToInt32(genislik.Text);
            }
            catch(Exception){
                a = 0;
            }
            int b = 0;
            try
            {
                b = System.Convert.ToInt32(yukseklik.Text);
            }
            catch (Exception)
            {
                b = 0;
            }
            int sonuc = a * b;
            MessageBox.Show("Dikdörtgenin Alanı ="+sonuc.ToString());
        }
    }
}
