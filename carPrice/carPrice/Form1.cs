using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double toDouble(string metin)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
