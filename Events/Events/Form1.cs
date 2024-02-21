using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button messageButton = new Button();
            messageButton.Left = 100;
            messageButton.Top = 100;
            messageButton.Width = 300;
            messageButton.Height = 80;
            messageButton.Text = "Mesajı Görüntüle";
            messageButton.Click += showMessage;
            messageButton.MouseEnter += showErrorMessage;
            this.Controls.Add(messageButton);
        }
        private void showMessage(object sender, EventArgs e) {
            MessageBox.Show("Butona Tıkladım");
        }
        private void showErrorMessage(object sender,EventArgs e) {
            Button b = sender as Button;
            b.BackColor = Color.DarkViolet;
        }
    }
}
