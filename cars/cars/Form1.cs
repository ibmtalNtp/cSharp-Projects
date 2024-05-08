using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private CarList cars;
        private void Form1_Load(object sender, EventArgs e)
        {
            cars = new CarList();
            cars.add(new Car("Passat CC", "Volkswagen", 789345, "Gri", 2021));
            cars.add(new Car("BMW 3.20i", "Mercedes", 478954, "Kırmızı", 2016));
            cars.Click += carInfo;
            this.Controls.Add(cars);
        }
        private void carInfo(object sender, EventArgs e)
        {
            CarList cars = sender as CarList;
            int tiklanan = cars.SelectedIndex;
            MessageBox.Show(cars.cars[tiklanan].name + " " + cars.cars[tiklanan].price);
        }
    }
}
