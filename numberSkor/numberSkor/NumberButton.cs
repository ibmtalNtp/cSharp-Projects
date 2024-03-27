using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace numberSkor
{
    class NumberButton : Button
    {
        public int number;
        public NumberButton(){
            Random rnd = new Random();
            this.number = rnd.Next(0,100);
        }
    }
}
