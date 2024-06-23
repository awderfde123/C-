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
    public partial class FMenu : Form
    {
        int blacktea = 0;
        int blackteaP = 50;
        int milktea = 0;
        int milkteaP = 60;
        int greentea = 0;
        int greenteaP = 40;
        int juice = 0;
        int juiceP = 65;
        string x="",y="",z="",q="";

        private void Btnmliktea_Click(object sender, EventArgs e)
        {
            milktea = milktea + 1;
            y = "奶茶 X " + milktea + " 共" + milktea * milkteaP + "$"+ Environment.NewLine;
            TotalList();
        }

        private void Btngreentea_Click(object sender, EventArgs e)
        {
            greentea = greentea + 1;
            z = "抹茶 X " + greentea + " 共" + greentea * greenteaP + "$"+ Environment.NewLine;
            TotalList();
        }


        private void Btnjuice_Click_1(object sender, EventArgs e)
        {
            juice = juice + 1;
            q = "柳橙汁 X " + juice + " 共" + juice * juiceP + "$"+ Environment.NewLine;
            TotalList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxbLixt.Text = "尚未點餐";
            blacktea = milktea = greentea = juice = 0;
            x = y = z = q = "";
            TxbTP.Text = "NT$ 0";
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+(blacktea * blackteaP + milktea * milkteaP + greentea * greenteaP + juice * juiceP),"現金");
        }

        private void Ccard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + ((blacktea * blackteaP + milktea * milkteaP + greentea * greenteaP + juice * juiceP)*0.9),"信用卡");
        }

        public FMenu()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            blacktea = blacktea + 1;
            x = "紅茶 X "+ blacktea + " 共"+ blacktea * blackteaP+ "$"+ Environment.NewLine;
            TotalList();
        }
        void TotalList() 
        {
           TxbTP.Text="NT$"+ (blacktea * blackteaP + milktea * milkteaP + greentea * greenteaP + juice * juiceP);
            TxbLixt.Text = x+y+z+q;
        }
    }
}
