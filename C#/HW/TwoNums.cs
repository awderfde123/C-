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
    public partial class TwoNums : Form
    {

        public TwoNums()
        {
            InitializeComponent();
        }

        private float Calculate(int num1, string CSymbol, int num2)
        {
            switch (CSymbol)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(TxbNum1.Text);
                int num2 = int.Parse(TxbNum2.Text);
                TxbAnswer.Text = "" + Calculate(num1, "+", num2);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(TxbNum1.Text);
                int num2 = int.Parse(TxbNum2.Text);
                TxbAnswer.Text = "" + Calculate(num1, "-", num2);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(TxbNum1.Text);
                int num2 = int.Parse(TxbNum2.Text);
                TxbAnswer.Text = "" + Calculate(num1, "*", num2);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void BtnDivided_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(TxbNum1.Text);
                int num2 = int.Parse(TxbNum2.Text);
                TxbAnswer.Text = "" + Calculate(num1, "/", num2);
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
