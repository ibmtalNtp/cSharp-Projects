using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace minefarm
{
    class Mine: Button
    {
        public int row;
        public int column;
        public int bomb;
        public Mine() {
 
        }
        public Mine(int r,int c,int b) {
            this.row = r;
            this.column = c;
            this.bomb = b;
            this.Width = 40;
            this.Height = 40;
            this.Left = c * 40;
            this.Top = r * 40;
        }

    }
}
