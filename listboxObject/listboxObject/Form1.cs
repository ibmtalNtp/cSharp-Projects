using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//        GraphicCard g1;
        ListBox liste;
        private void Form1_Load(object sender, EventArgs e)
        {
//            g1 = new GraphicCard("ASUS GEFORCE",2048,1023,true,36399.50);
//            MessageBox.Show(g1.name);
            liste = new ListBox();
            liste.Left = 100;
            this.Controls.Add(liste);
            //liste.Items.Add("ASUS GEFORCE X1");
            string[] listeEleman = new string[] { 
                                                   "ASUS GEFORCE PROART RTX 4070 TI 12GB  192bit GDDR6X 2760MHz OC 2xHDMI 3xDP (PROART-RTX4070TI-O12G) DLSS3 EKRAN KARTI"
                                                   ,"MSI VGA GEFORCE RTX 4060 GAMING X 8G RTX4060 8GB GDDR6 128B DX12 PCIE 4.0 X8 (3XDP 1XHDMI)"
                                                   ,"Gigabyte Geforce Rtx 4060 Eagle 8g GV-N4060EAGLE Oc-8gd Gddr6 128BIT DX12 Dlss 3 Gaming (Oyuncu) Ekran Kartı"
                                                };
            for (int i = 0; i < 3;i++ )
            {
                liste.Items.Add(listeEleman[i]);
            }




        }
    }
}
