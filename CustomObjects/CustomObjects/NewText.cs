using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomObjects
{
    class NewText : TextBox
    {
        public Font font;
        public NewText() {
            this.font = new Font("arial",20);
            this.Font = this.font;
            this.BackColor = Color.Blue;
        }
        public NewText(int left,int top,int width) {
            this.font = new Font("arial", 20);
            this.Font = this.font;
            this.Width = width;
            this.Left = left;
            this.Top = top;
            this.BackColor = Color.FromArgb(188,247,253);
        }

    }
}
