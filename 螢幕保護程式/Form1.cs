using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 螢幕保護程式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int delX = 10;
        int delY = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox1.Left += delX;
            this.pictureBox1.Top += delY;
            if (this.pictureBox1.Top < 0 || this.pictureBox1.Top + this.pictureBox1.Height > this.Height)
                delY = -delY;

            if (this.pictureBox1.Left < 0 || this.pictureBox1.Left + this.pictureBox1.Width > this.Width)
                delX = -delX;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

            private void Form1_Click(object sender, EventArgs e)
        {
                           Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int XStart, YStart;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           if (XStart==0 && YStart==0)
            {
                XStart = e.X;
                YStart = e.Y;
                return;
            }
            
            else if(e.X !=XStart || e.Y!=YStart)
            
            
            
            Application.Exit();
        }
    }
}
