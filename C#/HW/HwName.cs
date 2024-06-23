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
    public partial class HwName : Form
    {
        public HwName()
        {
            InitializeComponent();
        }

        private void SayHi_Click(object sender, EventArgs e)
        {
            string Name = TxbName.Text;
            string EName = TxbEName.Text;
            string Gender = TxbGender.Text;
            string Constellation = TxbConstellation.Text;

            MessageBox.Show("HI~~~~~\n姓名: " + Name + "\n英文名字: " + EName + "\n性別: " + Gender + "\n星座: " + Constellation);
        }

        private void SayHello_Click(object sender, EventArgs e)
        {
            string Name = TxbName.Text;
            string EName = TxbEName.Text;
            string Gender = TxbGender.Text;
            string Constellation = TxbConstellation.Text;

            MessageBox.Show("HELLO~~~~~\n姓名: " + Name + "\n英文名字: " + EName + "\n性別: " + Gender + "\n星座: " + Constellation);
        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
