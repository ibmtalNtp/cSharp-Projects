using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threeButtonEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b1 = new Button();
            b1.Left = 100;
            b1.Top = 50;
            b1.Width = 100;
            b1.Height = 50;
            b1.Text = "1";
            this.Controls.Add(b1);
            Button b2 = new Button();
            b2.Left = 220;
            b2.Top = 50;
            b2.Width = 100;
            b2.Height = 50;
            b2.Text = "2";
            this.Controls.Add(b2);
            Button b3 = new Button();
            b3.Left = 330;
            b3.Top = 50;
            b3.Width = 100;
            b3.Height = 50;
            b3.Text = "3";
            this.Controls.Add(b3);

            b1.MouseEnter += green;
            b2.MouseEnter += green;
            b3.MouseEnter += green;
            //b1.MouseLeave+=blue;
            //b1 in üzerinden fare ayrılınca mavi renk olsun
            //b2 in üzerinden fare ayrılınca Kırmızı renk olsun
            //b3 in üzerinden fare ayrılınca Siyah renk olsun
            //b1 e tıklayınca kırmızı renk olsun
        }

        private void green(object sender, EventArgs e) {
            Button b = sender as Button;
            b.BackColor = Color.FromArgb(167,240,20);
        }

        //yeni bir proje oluşturun. adı PressUp olsun
        // 1 tane buton oluşturun
        // mouseDown olayında butonun rengi mor
        //mouseUp olayında butonun rengi sarı olsun

    }
}
