using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Homepage : Form
    {

        public Homepage()
        {
            InitializeComponent();
        }

        private void HwName_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            HwName FName = new HwName();
            FName.MdiParent = this;
            FName.Parent = splitContainer2.Panel2;
            FName.Show();
        }

        private void BtnInterest_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            Interrest Interrest = new Interrest();
            Interrest.MdiParent = this;
            Interrest.Parent = splitContainer2.Panel2;
            Interrest.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            FMenu FMenu = new FMenu();
            FMenu.MdiParent = this;
            FMenu.Parent = splitContainer2.Panel2;
            FMenu.Show();
        }
        private void BtnGrade_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            Grade Grade = new Grade();
            Grade.MdiParent = this;
            Grade.Parent = splitContainer2.Panel2;
            Grade.Show();
        }

        private void BtnCalGrade_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            CalGrade CalGrade = new CalGrade();
            CalGrade.MdiParent = this;
            CalGrade.Parent = splitContainer2.Panel2;
            CalGrade.Show();
        }
        private void CloseMidChildren()
        {
            if(splitContainer2.Panel2.Controls.Count>0)
            splitContainer2.Panel2.Controls.Clear();
        }

        private void BtnMethod_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            Method Method = new Method();
            Method.MdiParent = this;
            Method.Parent = splitContainer2.Panel2;
            Method.Show();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            TwoNums TwoNums = new TwoNums();
            TwoNums.MdiParent = this;
            TwoNums.Parent = splitContainer2.Panel2;
            TwoNums.Show();
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            Game Game = new Game();
            Game.MdiParent = this;
            Game.Parent = splitContainer2.Panel2;
            Game.Show();
        }

        private void BtnScreenSave_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            ScreenSaver ScreenSaver = new ScreenSaver();
            ScreenSaver.Show();
        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "notepad.exe";
            p.Start();
        }

        private void BtnDrow_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            Drow Drow = new Drow();
            Drow.MdiParent = this;
            Drow.Parent = splitContainer2.Panel2;
            Drow.Show();
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            GuessGame GuessGame = new GuessGame();
            GuessGame.MdiParent = this;
            GuessGame.Parent = splitContainer2.Panel2;
            GuessGame.Show();
        }

        private void BtnClock_Click(object sender, EventArgs e)
        {
            CloseMidChildren();
            Clock Clock = new Clock();
            Clock.MdiParent = this;
            Clock.Parent = splitContainer2.Panel2;
            Clock.Show();
        }
    }
}
