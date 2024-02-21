using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0,0,0);

            NewLabel urunLabel = new NewLabel(0,50,"Ürün Adı");
            this.Controls.Add(urunLabel);
                  
            NewText urunAdi = new NewText(100, 50, 300);
            this.Controls.Add(urunAdi);
            
            NewLabel aciklamaLabel = new NewLabel(0, 100, "Ürün Açıklaması");
            this.Controls.Add(aciklamaLabel);

            NewText urunAciklama = new NewText(100, 100, 350);
            this.Controls.Add(urunAciklama);

            NewText urunFiyat = new NewText(100, 150, 80);
            this.Controls.Add(urunFiyat);
            NewText urunAdet = new NewText(100, 200, 90);
            this.Controls.Add(urunAdet);
            urunAdet.BackColor = Color.FromArgb(54,242,160);
        }
    }
}
