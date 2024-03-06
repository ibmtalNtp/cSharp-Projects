using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruitCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Card card;
        private List<Card> cards=new List<Card>();
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            PictureBox r1 = new PictureBox();
            r1.Image = Image.FromFile(@"..\..\fruits\apple.png");
            r1.SizeMode = PictureBoxSizeMode.StretchImage;
            r1.Width = 100;
            r1.Height = 100;
            this.Controls.Add(r1);
             */
            //card = new Card();
            //card.setFruit(4);
            //this.Controls.Add(card);
            int i, j;
            Card card;
            Random r = new Random();
            for (i = 0; i <4;i++ )
            {
                for (j = 0; j <4;j++ )
                {
                    card = new Card();
                    card.setFruit(r.Next(0,10));
                    card.Left = j * card.Width;
                    card.Top = i * card.Height;
                    card.row = i;
                    card.column = j;
                    cards.Add(card);
                    this.Controls.Add(card);
                }
            }


        }
    }
}
