using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomObjects
{
    class NewLabel : Label
    {
        public NewLabel() { 
            
        }
        public NewLabel(int left,int top, string text) {
            this.Left = left;
            this.Top = top;

            this.Text = text;
            this.ForeColor = Color.FromArgb(245,219,54);
        }
    }
}
