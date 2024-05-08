using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaatmaliyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private double toDoble(string metin) {
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
        private void hesapla_Click(object sender, EventArgs e)
        {
            cimentoTutar.Text = (
                    toDoble(cimentoMiktar.Text) * toDoble(cimentoBirimFiyat.Text)
                ).ToString();
            demirTutar.Text=(toDoble(demirMiktar.Text)*toDoble(demirBirimFiyat.Text)).ToString();
        }
    }
}
