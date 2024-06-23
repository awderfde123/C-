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
    public partial class Interrest : Form
    {
        public Interrest()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            LabMomth.Text  = "期數";
            LabMomthM.Text = "償還本金";
            LabMonthR.Text = "償還利息";
            LabMonthT.Text = "本期應繳金額";
            TxbTotalR.Text = "全部利息";
            try

            {
                int TotalRateM=0;
                int TotalM = int.Parse(TxbTotalM.Text);
                float Rate = float.Parse(TxbRate.Text);
                int RateM = int.Parse(TxbRateM.Text);
                int principal = (int)(((float)TotalM / (float)RateM) + 0.5);
                float MRate = (Rate / 100) / 12 ;
                int TRate = (int)((TotalM * MRate) + 0.5);

                for (int x = 1; x <= RateM; x++)
                {
                    LabMomth.Text = LabMomth.Text + "\n\n" + x;
                    LabMomthM.Text = LabMomthM.Text + "\n\n" + principal;
                    LabMonthR.Text = LabMonthR.Text + "\n\n" + TRate;
                    LabMonthT.Text = LabMonthT.Text + "\n\n" + (principal + TRate);
                    TotalRateM = TotalRateM + TRate;
                    TRate = (int)(((TotalM - principal) * MRate) + 0.5);
                    TotalM = TotalM - principal;
                }
                TxbTotalR.Text = ""+TotalRateM;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Interrest_Load(object sender, EventArgs e)
        {}
    }
}
