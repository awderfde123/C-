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
    public partial class GuessGame : Form
    {
        int num = new Random().Next(1, 100);
        int high = 100;
        int low = 1;
        public GuessGame()
        {
            InitializeComponent();
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            Guess Guess = new Guess();
            Guess.ChangeText += new Guess.ChangeTextRange(Change_Text);
            Guess.ShowDialog();
        }
        public void Change_Text(int num)
         {
            if (num > low && num < high)
            {
                if (num > this.num)
                {
                    high = num;
                    LabGuess.Text = "數字太高了 \n在"+low+"~"+high+"之間";
                }
                else if (num < this.num)
                {
                    low = num;
                    LabGuess.Text = "數字太低了 \n在" + low + "~" + high + "之間";
                }
                else
                    LabGuess.Text = "恭喜猜中了";
            }
            else
                MessageBox.Show("請輸入範圍內數字");
         }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            GuessAnswer GuessAnswer = new GuessAnswer(num);
            GuessAnswer.ShowDialog();
        }

        private void GuessGame_Load(object sender, EventArgs e)
        {

        }
    }
}
