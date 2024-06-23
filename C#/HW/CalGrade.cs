using System;
using System.Collections;
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
    public partial class CalGrade : Form
    {
        ArrayList CalName = new ArrayList();
        ArrayList Chinese = new ArrayList();
        ArrayList English = new ArrayList();
        ArrayList Math = new ArrayList();
        int rndName=1;
        public CalGrade()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StdCalculate(TxbName.Text,int.Parse(TxbChinese.Text), int.Parse(TxbEnglish.Text), int.Parse(TxbMath.Text));
                ViewClear();
                PrintGrade();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void StdCalculate(string Name, int Chinese, int English, int Math)
        {
            this.CalName.Add(Name);
            this.Chinese.Add(Chinese);
            this.English.Add(English);
            this.Math.Add(Math);
        }

        private string StdHigh(int Chinese, int English, int Math)
        {
            if (Chinese > English && Chinese > Math) return "國文" + Chinese;
            else if (English > Chinese && English > Math) return "英文" + English;
            else if (Math > English && Math > Chinese) return "數學" + Math;
            else return "X";
        }

        private string StdLow(int Chinese,int English,int Math)
        {
            if (Chinese < English && Chinese < Math) return "國文" + Chinese;
            else if (English < Chinese && English < Math) return "英文" + English;
            else if (Math < English && Math < Chinese) return "數學" + Math;
            else return "X";
        }


        private void BtnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Chinese = rnd.Next(60, 100);
            int English = rnd.Next(60, 100);
            int Math = rnd.Next(60, 100);
            string Name = "" + rndName++;
            StdCalculate(Name, Chinese, English, Math);
            ViewClear();
            PrintGrade();
        }

        private void PrintGrade()
        {
            for (int x = 0; x < this.CalName.Count; x++)
            {
                LabviewName.Text += this.CalName[x] + "\n";
                LabviewChinese.Text += "" + this.Chinese[x] + "\n";
                LabviewEnglish.Text += "" + this.English[x] + "\n";
                LabviewMath.Text += "" + this.Math[x] + "\n";
                LabviewAvg.Text += (((int)this.Chinese[x] + (int)this.English[x] + (int)this.Math[x]) / 3) + "\n";
                LabviewLow.Text += StdLow((int)this.Chinese[x], (int)this.English[x], (int)this.Math[x]) + "\n";
                LabviewHigh.Text += StdHigh((int)this.Chinese[x], (int)this.English[x], (int)this.Math[x]) + "\n";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ViewClear();
            CalName.Clear();
            Chinese.Clear();
            English.Clear();
            Math.Clear();
            rndName = 1;

        }

        private void ViewClear()
        {
            LabviewName.Text = "";
            LabviewChinese.Text = "";
            LabviewEnglish.Text = "";
            LabviewMath.Text = "";
            LabviewLow.Text = "";
            LabviewHigh.Text = "";
            LabviewAvg.Text = "";
        }

        private void BtnMRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int x = 1; x <= 20; x++)
            {
                int Chinese = rnd.Next(60, 100);
                int English = rnd.Next(60, 100);
                int Math = rnd.Next(60, 100);
                string Name = "" + rndName++;
                StdCalculate(Name, Chinese, English, Math);
            }
            ViewClear();
            PrintGrade();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int[] SChinese = SubjectCalcilate(Chinese);
                LabSujestTotalC.Text = "" + SChinese[0];
                LabSujestAvgC.Text = "" + SChinese[1];
                LabSujestLowC.Text = "" + SChinese[2];
                LabSujestHighC.Text = "" + SChinese[3];
                int[] SEnglish = SubjectCalcilate(English);
                LabSujestTotalE.Text = "" + SEnglish[0];
                LabSujestAvgE.Text = "" + SEnglish[1];
                LabSujestLowE.Text = "" + SEnglish[2];
                LabSujestHighE.Text = "" + SEnglish[3];
                int[] SMath = SubjectCalcilate(Math);
                LabSujestTotalM.Text = "" + SMath[0];
                LabSujestAvgM.Text = "" + SMath[1];
                LabSujestLowM.Text = "" + SMath[2];
                LabSujestHighM.Text = "" + SMath[3];
            }
            catch (Exception)
            {
                MessageBox.Show("目前沒有資料");
            }
        }

        private int [] SubjectCalcilate(ArrayList Subject)
        {
            int Total = 0;
            int LTemp = (int)Subject[0];
            int HTemp = (int)Subject[0];
            int[] Return = new int[4];
            for (int x = 0; x < Subject.Count; x++)
            {
                Total = Total + (int)Subject[x];
                if (HTemp < (int)Subject[x])
                {
                    HTemp = (int)Subject[x];
                }
                if (LTemp > (int)Subject[x])
                {
                    LTemp = (int)Subject[x];
                }
            }
            Return[0] = Total;
            Return[1] = (Total/ Subject.Count);
            Return[2] = LTemp;
            Return[3] = HTemp;
            return Return;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int low = int.Parse(TxbSlow.Text);
                int High = int.Parse(TxbShigh.Text);
                ViewClear();
                for (int x = 0; x < Chinese.Count; x++)
                {
                    if ((int)Chinese[x] >= low && (int)Chinese[x] <= High)
                    {
                        LabviewName.Text += CalName[x]+"\n";
                        LabviewChinese.Text += ""+Chinese[x] + "\n";
                        LabviewEnglish.Text += ""+English[x] + "\n";
                        LabviewMath.Text += ""+Math[x] + "\n";
                        LabviewAvg.Text += ""+((int)Chinese[x] + (int)English[x] + (int)Math[x]) / 3 + "\n";
                        LabviewLow.Text += ""+StdLow((int)Chinese[x], (int)English[x], (int)Math[x]) + "\n";
                        LabviewHigh.Text += ""+StdHigh((int)Chinese[x], (int)English[x], (int)Math[x]) + "\n";
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void BtnStdInsert_Click(object sender, EventArgs e)
        {
            try
            {
                this.CalName.Insert(0,int.Parse(TxbName.Text));
                this.Chinese.Insert(0, int.Parse(TxbChinese.Text));
                this.English.Insert(0, int.Parse(TxbEnglish.Text));
                this.Math.Insert(0, int.Parse(TxbMath.Text));
                ViewClear();
                PrintGrade();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.CalName.RemoveAt(CalName.Count - 1);
                this.Chinese.RemoveAt(Chinese.Count - 1);
                this.English.RemoveAt(English.Count - 1);
                this.Math.RemoveAt(Math.Count-1);
                rndName--;
            }
            catch (Exception)
            {
                MessageBox.Show("目前沒有資料");
            }
            ViewClear();
            PrintGrade();
        }

    }
}
