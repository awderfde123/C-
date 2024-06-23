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
    public partial class Clock : Form
    {
        string str;
        public Clock()
        {
            InitializeComponent();
            DateTime Time = DateTime.Now;
            LabClock.Text = Plus0(Time.Hour) + ":" + Plus0(Time.Minute) + ":" + Plus0(Time.Second);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            LabClock.Text = Plus0(Time.Hour) + ":" + Plus0(Time.Minute) + ":" + Plus0(Time.Second);
            if (LabClock.Text == str)
            {
                //System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("123");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                str = textBox1.Text;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }
        string Plus0(int num)
        {
            return num >= 10 ? "" + num : "0" + num;
        }
    }
}
