using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Drow : Form
    {
        int xMouse;
        int yMouse;
        Boolean IsMouseDown = false;
        Graphics g;
        Pen p;
        Color color = Color.Black;
        int width = 1;
        public Drow()
        {
            InitializeComponent();
        }

        private void Drow_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Pen(color, width);
            g = this.CreateGraphics();
            xMouse = e.X;
            yMouse = e.Y;
            // MessageBox.Show("" + xMouse +"  " + yMouse);
            IsMouseDown = true;
        }

        private void Drow_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                g.DrawLine(p, xMouse, yMouse, e.X, e.Y);
                xMouse = e.X;
                yMouse = e.Y;
            }
        }

        private void Drow_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
            LabColorView.BackColor = color;
        }

        private void TkbWidth_Scroll(object sender, EventArgs e)
        {
            width = TkbWidth.Value;
            LabWidth.Text = ""+TkbWidth.Value;
        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            color = Color.FromArgb(224, 224, 224);
        }

        private void Drow_Load(object sender, EventArgs e)
        {

        }
    }
}
