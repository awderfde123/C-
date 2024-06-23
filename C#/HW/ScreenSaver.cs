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
    public partial class ScreenSaver : Form
    {
        Boolean xLine = true;
        Boolean yLine = true;
        int xMouse = Cursor.Position.X;
        int yMouse = Cursor.Position.Y;
        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            TimerMove.Start();
        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            Rectangle WorkArea = Screen.GetWorkingArea(this);
            if (yLine)
            {
                if (PtbMove.Location.Y < WorkArea.Height - 170)
                    PtbMove.Location = new Point(PtbMove.Location.X, PtbMove.Location.Y + 10);
                else
                {
                    PtbMove.Location = new Point(PtbMove.Location.X, PtbMove.Location.Y - 10);
                    yLine = false;
                }
            }
            else
            {
                if (PtbMove.Location.Y > 0)
                    PtbMove.Location = new Point(PtbMove.Location.X, PtbMove.Location.Y - 10);
                else
                {
                    PtbMove.Location = new Point(PtbMove.Location.X, PtbMove.Location.Y + 10);
                    yLine = true;
                }
            }
            if (xLine)
            {
                if (PtbMove.Location.X < WorkArea.Width - 225)
                    PtbMove.Location = new Point(PtbMove.Location.X + 20, PtbMove.Location.Y);
                else
                {
                    PtbMove.Location = new Point(PtbMove.Location.X - 20, PtbMove.Location.Y);
                    xLine = false;
                }
            }
            else
            {
                if (PtbMove.Location.X > 0)
                    PtbMove.Location = new Point(PtbMove.Location.X - 20, PtbMove.Location.Y);
                else
                {
                    PtbMove.Location = new Point(PtbMove.Location.X + 20, PtbMove.Location.Y);
                    xLine = true;
                }
            }
            if (xMouse - 60 > Cursor.Position.X || Cursor.Position.X > xMouse + 60)
            {
                this.Close();
            }
            if (yMouse - 60 > Cursor.Position.Y || Cursor.Position.Y > yMouse + 60)
            {
                this.Close();
            }
        }

        private void PtbMove_Click(object sender, EventArgs e)
        {

        }
    }
}
