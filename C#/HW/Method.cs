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
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void BtnEven_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(TxbEven.Text);
                if (num % 2 == 0)
                {
                    LabView.Text = "偶數";
                }
                else 
                {
                    LabView.Text = "奇數";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void BtnArrayEven_Click(object sender, EventArgs e)
        {
            int[] num = new[] { 1, 50, 6, 43, 28, 99, 6, 10, 22 };
            int count = 0;
            LabView.Text = "陣列有 : { ";
            for (int x=0; x < num.Length; x++)
            {
                if (num[x] % 2 == 0)
                    count++;
                LabView.Text += + num[x] + ",";
            }
            LabView.Text += " }\n";
            LabView.Text += "偶數有 : " + count + "個  奇數是 : " + (num.Length - count) + "個";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] num = new[] {"Abraham", "Bertran", "Bradford", "Dominic", "Eugene", "Gilbert", "Humprey", "Karl" };
            int longerst = num[0].Length;
            string Temp = num[0];
            LabView.Text = "陣列有 : { ";
            for (int x = 0; x < num.Length; x++)
            {
                if (num[x].Length > longerst)
                {
                    longerst = num[x].Length;
                    Temp = num[x];
                }
                LabView.Text += num[x] + ", ";
            }
            LabView.Text += " }\n";
            LabView.Text += "最長字元是 : " + Temp + "     共" + longerst + "個字元";
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            int[] num = new[] { 17, 50, 6, 43, 28, 85, 6, 10, 22 };
            int HTemp = num[0];
            int LTemp = num[0];
            LabView.Text = "陣列有 : { ";
            for (int x = 0; x < num.Length; x++)
            {
                if (num[x] > HTemp)
                    HTemp = num[x];
                if (LTemp > num[x])
                    LTemp = num[x];
                LabView.Text += +num[x] + ",";
            }
            LabView.Text += " }\n";
            LabView.Text += "最大值是 : " + HTemp + "   最小值是 : " + LTemp;
        }

        private void BtnSerch_Click(object sender, EventArgs e)
        {
            string[] num = new[] { "Clement", "Bertran", "Isaac", "Dominic", "Eugene", "Christian", "Humprey", "Clyde" };
            int countC = 0;
            int countc = 0;
            LabView.Text = "陣列有 : { ";
            for (int x = 0; x < num.Length; x++)
            {
                for( int y=0;y < num[x].Length;y++)
                {
                    if (num[x][y] == 'C')
                    {
                        countC++;
                        break;
                    }
                    if (num[x][y] == 'c')
                    {
                        countc++;
                        break;
                    }
                }
                LabView.Text += num[x] + ", ";
            }
            LabView.Text += " }\n";
            LabView.Text += "有C的名子共 : " + countC + "個    有c的名子共 : " + countc +"個";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LabView.Text = "結果";
        }

        private void BtnTArray1_Click(object sender, EventArgs e)
        {
            string[,] TArray = new string[10,10];
            LabView.Text = "";
            for (int x = 0; x < TArray.GetLength(0); x++)
            {
                for (int y = 0; y < TArray.GetLength(1); y++)
                {
                    if (x == 0 || x == TArray.GetLength(0)-1 || y == 0 || y == TArray.GetLength(1)-1)
                        TArray[x,y] = "1";
                    else
                        TArray[x, y] = "0";
                }
            }
            for (int x = 0; x < TArray.GetLength(0); x++)
            {
                for (int y = 0; y < TArray.GetLength(1); y++)
                {
                    LabView.Text += TArray[x, y];
                }
                LabView.Text += "\n";
            }
        }

        private void BtnTArray2_Click(object sender, EventArgs e)
        {
            string[,] TArray = new string[10, 10];
            LabView.Text = "";
            for (int x = 0; x < TArray.GetLength(0); x++)
            {
                for (int y = 0; y < TArray.GetLength(1); y++)
                {
                    if (x == 0 || x == TArray.GetLength(0) - 1 || y == 0 || y == TArray.GetLength(1) - 1)
                        TArray[x, y] = "0";
                    else
                        TArray[x, y] = "1";
                }
            }
            for (int x = 0; x < TArray.GetLength(0); x++)
            {
                for (int y = 0; y < TArray.GetLength(1); y++)
                {
                    LabView.Text += TArray[x, y];
                }
                LabView.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            string[,] TArray = new string[10, 10];
            LabView.Text = "";
            for (int x = 0; x < TArray.GetLength(0); x++)
            {
                if (x % 2 == 0)
                    num = 0;
                else
                    num = 1;
                for (int y = 0; y < TArray.GetLength(1); y++)
                {
                    if (num==2)
                    num = 0;
                    TArray[x, y] = "" + num;
                    num++;
                }
            }
            for (int x = 0; x < TArray.GetLength(0); x++)
            {
                for (int y = 0; y < TArray.GetLength(1); y++)
                {
                    LabView.Text += TArray[x, y];
                }
                LabView.Text += "\n";
            }
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            int[] Array = new int[] {120,340};
            int Temp;
            LabView.Text = "第一位是 : " + Array[0] + "    第二位是 : " + Array[1];
            Temp = Array[0];
            Array[0] = Array[1];
            Array[1] = Temp;
            LabView.Text += "\n第一位是 : " + Array[0] + "    第二位是 : " + Array[1];
        }

        private void BtnArraySum_Click(object sender, EventArgs e)
        {
            int[] num = new[] { 17, 50, 6, 43, 28, 85, 6, 10, 22 };
            int sum = 0;
            LabView.Text = "陣列有 : { ";
            for (int x = 0; x < num.Length; x++)
            {
                sum += num[x];
                LabView.Text += num[x] + ", ";
            }
            LabView.Text += " }\n";
            LabView.Text += "加總是 : " + sum;
        }

        private void BtnBinary_Click(object sender, EventArgs e)
        {
            try
            {
                LabView.Text = Convert.ToString(int.Parse(TxbCal.Text), 2);
                while (LabView.Text.Length < 4)
                {
                    LabView.Text = "0" + LabView.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Temp = "";
            try
            {
                for (int x = 1; x <= int.Parse(TxbCal.Text); x++)
                {
                    for (int y = 1; y <= x; y++)
                    {
                        Temp += "*";
                    }
                    Temp += "\n";
                }
                LabView.Text = Temp;
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void BtnBingo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string Temp = "";
            try
            {
                for (int x = 1; x <= int.Parse(TxbCal.Text); x++)
                {
                    for (int y = 1; y <= 6; y++)
                    {
                        Temp += PlsO(rnd.Next(1,49))+"," ;
                    }
                    Temp += "\n";
                }
                LabView.Text = Temp;
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private string PlsO(int num)
        {
            if (num < 10)
                return "0" + num;
            else
                return ""+num;
        }

        private void BtnMtable_Click(object sender, EventArgs e)
        {
            string Temp="";
            for (int x = 1; x <=9; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    Temp += PlsO(y) + "X" + PlsO(x) + "=" + PlsO(x * y) + "  ";
                }
                Temp += "\n";
            }
            LabView.Text = Temp;
        }
    }
}
