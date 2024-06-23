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
    public partial class Grade : Form
    {
        int Chinese, English, Math;

        public Grade()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Chinese = int.Parse(TxbChinese.Text);
                English = int.Parse(TxbEnglish.Text);
                Math = int.Parse(TxbMath.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Grade_Load(object sender, EventArgs e)
        {

        }

        private void LabShow1_Click(object sender, EventArgs e)
        {

        }

        private void TxbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabShow1.Text = "姓名 :" +TxbName.Text + "\n國文 :" + Chinese + "\n英文 :" + English + "\n數學 :" + Math;
        }
        private void BtnHF_Click(object sender, EventArgs e)
        {
            if (Chinese > English && Chinese > Math) LabShow2.Text = "最高分國文是 :" + Chinese;
            else if (English > Chinese && English > Math) LabShow2.Text = "最高分英文是 :" + English;
            else if (Math > English && Math > Chinese) LabShow2.Text = "最高分數學是 :" + Math;
            else LabShow2.Text = "沒有最高分";
            if (Chinese < English && Chinese < Math) LabShow2.Text += "\n最低分國文是 :" + Chinese;
            else if (English < Chinese && English < Math) LabShow2.Text+= "\n最低分英文是 :" + English;
            else if (Math < English && Math < Chinese) LabShow2.Text += "\n最低分數學是 :" + Math;
            else LabShow2.Text += "\n沒有最低分";
        }
    }
}
