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

        private void carCalculate_Click(object sender, EventArgs e)
        {

            string name = carName.Text;
            double model = toDouble(carModel.Text);
            double modelPercent = toDouble(carModelPercent.Text);
            double modelValue = 0;
            double maxPrice = toDouble(carMaxPrice.Text);
            double extimatedValue = maxPrice;
            modelValue = (2024 - model) / 100 * modelPercent * maxPrice;
            carModelValue.Text = modelValue.ToString();
            extimatedValue = extimatedValue - modelValue;
            carEstimatedValue.Text = extimatedValue.ToString();
        }
    }
}
