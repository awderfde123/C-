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
    public partial class Game : Form
    {
        Boolean O = false;
        int count = 0;
        public Game()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = isO() ? "O" : "X";
            button1.Enabled = false;
            Iswin();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = isO() ? "O" : "X";
                button2.Enabled = false;
            Iswin();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = isO() ? "O" : "X";
                button3.Enabled = false;
            Iswin();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = isO() ? "O" : "X";
                button4.Enabled = false;
            Iswin();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = isO() ? "O" : "X";
                button5.Enabled = false;
            Iswin();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = isO() ? "O" : "X";
                button6.Enabled = false;
            Iswin();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = isO() ? "O" : "X";
                button7.Enabled = false;
            Iswin();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = isO() ? "O" : "X";
                button8.Enabled = false;
            Iswin();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = isO() ? "O" : "X";
                button9.Enabled = false;
            Iswin();
        }


        private Boolean isO()
        {
            O = !O;
            return O;
        }
        private void Iswin()
        {
            count++;
            string[,] wincondition = new string[8, 3]
            {{button1.Text,button2.Text,button3.Text },{button4.Text,button5.Text,button6.Text },{button7.Text,button8.Text,button9.Text },
            {button1.Text,button4.Text,button7.Text },{button2.Text,button5.Text,button8.Text },{button3.Text,button6.Text,button9.Text },
            {button1.Text,button5.Text,button9.Text },{button3.Text,button5.Text,button7.Text }};
            for(int x=0;x< wincondition.GetLength(0);x++)
            {
               if(wincondition[x,0]== wincondition[x, 1] && wincondition[x, 1]== wincondition[x, 2])
                {
                    if (wincondition[x, 1] == "O")
                    {
                        MessageBox.Show("圈圈贏了YA");
                        BtnReset_Click(null, null);
                    }
                    else if (wincondition[x, 1] == "X")
                    {
                        MessageBox.Show("叉叉贏了YA");
                        BtnReset_Click(null, null);
                    }
                }
            }
            if(count == 9)
            {
                MessageBox.Show("沒有人贏~");
                BtnReset_Click(null, null);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.R)
                BtnReset_Click(null, null);
            if (e.KeyCode == Keys.Escape)
                BtnExit_Click(null, null);
        }
    }
}
