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
    public partial class Guess : Form
    {
        public delegate void ChangeTextRange(int num);
        public Guess()
        {
            InitializeComponent();
        }
        public event ChangeTextRange ChangeText;
        private void Btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                    ChangeText(int.Parse(textBox1.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("請輸入數字");
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                Btncheck_Click(sender, e);
            }
        }

        private void Guess_Load(object sender, EventArgs e)
        {

        }
    }
}
