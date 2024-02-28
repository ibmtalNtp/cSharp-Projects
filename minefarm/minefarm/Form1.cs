using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minefarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Mine m11;
        private Mine m22;
        private List<Mine> mine;
        
        private void checkBomb(object sender,EventArgs e) {
            //sender değişkeni gelen nesneyi belirtir

            Mine m = sender as Mine;//tıklanan buton m'dir
        //    MessageBox.Show("Satır : "+m.row);
        //    MessageBox.Show("sütun : "+m.column);
           
            if (m.bomb == 1)//tıklanan mine butonunun bomb'u 1 mi?
            {
                //m.bomb'un değeri 1 ise burası çalışacak
                m.Text = "X";//tıklanan butona X yaz
            }
            else {
                //m.bomb'un değeri 1 değil ise burası çalışacak
                m.Visible = false;//tıklanan butonu gizle
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            m11 = new Mine(1,1,0);
            m22 = new Mine(2,2,1);
            this.Controls.Add(m11);
            this.Controls.Add(m22);
            */
            mine = new List<Mine>();
            this.Width = 416;
            this.Height = 440;
            int i, j;
            Random rnd = new Random();
            for (i = 0; i < 100;i++ )
            {
                mine.Add(new Mine(i/10,i%10,0));
                mine[i].bomb = rnd.Next(2);
                mine[i].Click += checkBomb;

                this.Controls.Add(mine[i]);
            }
        }
    }
}
