using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace fruitCards
{
    class Card : PictureBox
    {
        public string[] fruits = { "apple.png", "grape.png", "ananas.png", "banana.png", "nar.jfif", "orange.jfif", "peach.jfif", "plum.jfif", "sweetcorn.png", "watermelon.jfif" };
        public int fruitNumber;
        public int row;
        public int column;
        public Card() {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Width = 100;
            this.Height = 100;
            this.Image = Image.FromFile(@"..\..\fruits\card.png");
            this.fruitNumber = -1;
        }
        public void setFruit(int meyveno) {
            this.fruitNumber = meyveno;
            this.Image = Image.FromFile(@"..\..\fruits\"+fruits[meyveno]);
        }



    }
}
