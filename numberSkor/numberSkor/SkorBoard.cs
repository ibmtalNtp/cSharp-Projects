using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace numberSkor
{
    class SkorBoard :Label
    {
        public int skor;
        public SkorBoard() {
            this.skor = 0;
            this.Text = this.skor.ToString();
        }
        public void addSkor(int a) {
        
        }

    }
}
