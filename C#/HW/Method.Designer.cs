
namespace HW
{
    partial class Method
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxbEven = new System.Windows.Forms.TextBox();
            this.BtnEven = new System.Windows.Forms.Button();
            this.LabResult = new System.Windows.Forms.Label();
            this.LabView = new System.Windows.Forms.Label();
            this.BtnArrayEven = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSize = new System.Windows.Forms.Button();
            this.BtnSerch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnTArray1 = new System.Windows.Forms.Button();
            this.BtnTArray2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.BtnArraySum = new System.Windows.Forms.Button();
            this.BtnBinary = new System.Windows.Forms.Button();
            this.TxbCal = new System.Windows.Forms.TextBox();
            this.BtnFor = new System.Windows.Forms.Button();
            this.BtnMtable = new System.Windows.Forms.Button();
            this.BtnBingo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxbEven
            // 
            this.TxbEven.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxbEven.Location = new System.Drawing.Point(12, 12);
            this.TxbEven.Name = "TxbEven";
            this.TxbEven.Size = new System.Drawing.Size(100, 27);
            this.TxbEven.TabIndex = 1;
            // 
            // BtnEven
            // 
            this.BtnEven.Location = new System.Drawing.Point(118, 12);
            this.BtnEven.Name = "BtnEven";
            this.BtnEven.Size = new System.Drawing.Size(99, 28);
            this.BtnEven.TabIndex = 2;
            this.BtnEven.Text = "是奇數或偶數";
            this.BtnEven.UseVisualStyleBackColor = true;
            this.BtnEven.Click += new System.EventHandler(this.BtnEven_Click);
            // 
            // LabResult
            // 
            this.LabResult.AutoSize = true;
            this.LabResult.BackColor = System.Drawing.Color.Transparent;
            this.LabResult.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabResult.Location = new System.Drawing.Point(12, 219);
            this.LabResult.Name = "LabResult";
            this.LabResult.Size = new System.Drawing.Size(84, 27);
            this.LabResult.TabIndex = 3;
            this.LabResult.Text = "Result:";
            // 
            // LabView
            // 
            this.LabView.AutoSize = true;
            this.LabView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabView.Font = new System.Drawing.Font("新細明體", 12F);
            this.LabView.Location = new System.Drawing.Point(28, 246);
            this.LabView.Name = "LabView";
            this.LabView.Size = new System.Drawing.Size(40, 16);
            this.LabView.TabIndex = 4;
            this.LabView.Text = "結果";
            // 
            // BtnArrayEven
            // 
            this.BtnArrayEven.Location = new System.Drawing.Point(118, 172);
            this.BtnArrayEven.Name = "BtnArrayEven";
            this.BtnArrayEven.Size = new System.Drawing.Size(106, 34);
            this.BtnArrayEven.TabIndex = 5;
            this.BtnArrayEven.Text = "陣列統計奇偶數";
            this.BtnArrayEven.UseVisualStyleBackColor = true;
            this.BtnArrayEven.Click += new System.EventHandler(this.BtnArrayEven_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "陣列最長字元";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSize
            // 
            this.BtnSize.Location = new System.Drawing.Point(6, 172);
            this.BtnSize.Name = "BtnSize";
            this.BtnSize.Size = new System.Drawing.Size(106, 34);
            this.BtnSize.TabIndex = 7;
            this.BtnSize.Text = "陣列大小值";
            this.BtnSize.UseVisualStyleBackColor = true;
            this.BtnSize.Click += new System.EventHandler(this.BtnSize_Click);
            // 
            // BtnSerch
            // 
            this.BtnSerch.Location = new System.Drawing.Point(118, 132);
            this.BtnSerch.Name = "BtnSerch";
            this.BtnSerch.Size = new System.Drawing.Size(106, 34);
            this.BtnSerch.TabIndex = 8;
            this.BtnSerch.Text = "陣列C,c個數";
            this.BtnSerch.UseVisualStyleBackColor = true;
            this.BtnSerch.Click += new System.EventHandler(this.BtnSerch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(411, 404);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(106, 34);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "清空結果欄";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnTArray1
            // 
            this.BtnTArray1.Font = new System.Drawing.Font("新細明體", 10F);
            this.BtnTArray1.Location = new System.Drawing.Point(260, 12);
            this.BtnTArray1.Name = "BtnTArray1";
            this.BtnTArray1.Size = new System.Drawing.Size(116, 51);
            this.BtnTArray1.TabIndex = 10;
            this.BtnTArray1.Text = "二維陣列 10*10\r\n邊1,內0";
            this.BtnTArray1.UseVisualStyleBackColor = true;
            this.BtnTArray1.Click += new System.EventHandler(this.BtnTArray1_Click);
            // 
            // BtnTArray2
            // 
            this.BtnTArray2.Font = new System.Drawing.Font("新細明體", 10F);
            this.BtnTArray2.Location = new System.Drawing.Point(260, 69);
            this.BtnTArray2.Name = "BtnTArray2";
            this.BtnTArray2.Size = new System.Drawing.Size(116, 51);
            this.BtnTArray2.TabIndex = 11;
            this.BtnTArray2.Text = "二維陣列 10*10\r\n邊0,內1";
            this.BtnTArray2.UseVisualStyleBackColor = true;
            this.BtnTArray2.Click += new System.EventHandler(this.BtnTArray2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 10F);
            this.button2.Location = new System.Drawing.Point(260, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 51);
            this.button2.TabIndex = 12;
            this.button2.Text = "二維陣列 10*10\r\n奇0偶1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSwap
            // 
            this.BtnSwap.Location = new System.Drawing.Point(6, 92);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(106, 34);
            this.BtnSwap.TabIndex = 13;
            this.BtnSwap.Text = "陣列換位";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // BtnArraySum
            // 
            this.BtnArraySum.Location = new System.Drawing.Point(6, 134);
            this.BtnArraySum.Name = "BtnArraySum";
            this.BtnArraySum.Size = new System.Drawing.Size(106, 34);
            this.BtnArraySum.TabIndex = 14;
            this.BtnArraySum.Text = "陣列Sum";
            this.BtnArraySum.UseVisualStyleBackColor = true;
            this.BtnArraySum.Click += new System.EventHandler(this.BtnArraySum_Click);
            // 
            // BtnBinary
            // 
            this.BtnBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBinary.Location = new System.Drawing.Point(417, 46);
            this.BtnBinary.Name = "BtnBinary";
            this.BtnBinary.Size = new System.Drawing.Size(100, 27);
            this.BtnBinary.TabIndex = 15;
            this.BtnBinary.Text = "數字轉二進制";
            this.BtnBinary.UseVisualStyleBackColor = false;
            this.BtnBinary.Click += new System.EventHandler(this.BtnBinary_Click);
            // 
            // TxbCal
            // 
            this.TxbCal.Font = new System.Drawing.Font("新細明體", 10F);
            this.TxbCal.Location = new System.Drawing.Point(417, 13);
            this.TxbCal.Name = "TxbCal";
            this.TxbCal.Size = new System.Drawing.Size(100, 23);
            this.TxbCal.TabIndex = 16;
            // 
            // BtnFor
            // 
            this.BtnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnFor.Location = new System.Drawing.Point(417, 79);
            this.BtnFor.Name = "BtnFor";
            this.BtnFor.Size = new System.Drawing.Size(100, 27);
            this.BtnFor.TabIndex = 17;
            this.BtnFor.Text = "直角聖誕樹";
            this.BtnFor.UseVisualStyleBackColor = false;
            this.BtnFor.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnMtable
            // 
            this.BtnMtable.Location = new System.Drawing.Point(411, 152);
            this.BtnMtable.Name = "BtnMtable";
            this.BtnMtable.Size = new System.Drawing.Size(106, 34);
            this.BtnMtable.TabIndex = 18;
            this.BtnMtable.Text = "九九乘法表";
            this.BtnMtable.UseVisualStyleBackColor = true;
            this.BtnMtable.Click += new System.EventHandler(this.BtnMtable_Click);
            // 
            // BtnBingo
            // 
            this.BtnBingo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBingo.Location = new System.Drawing.Point(417, 112);
            this.BtnBingo.Name = "BtnBingo";
            this.BtnBingo.Size = new System.Drawing.Size(100, 27);
            this.BtnBingo.TabIndex = 19;
            this.BtnBingo.Text = "樂透號碼6個";
            this.BtnBingo.UseVisualStyleBackColor = false;
            this.BtnBingo.Click += new System.EventHandler(this.BtnBingo_Click);
            // 
            // Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::HW.Properties.Resources.DD_Wall_Texture_22102_DD_Wall_Texture_22102_Preview;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.BtnBingo);
            this.Controls.Add(this.BtnMtable);
            this.Controls.Add(this.BtnFor);
            this.Controls.Add(this.TxbCal);
            this.Controls.Add(this.BtnBinary);
            this.Controls.Add(this.BtnArraySum);
            this.Controls.Add(this.BtnSwap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnTArray2);
            this.Controls.Add(this.BtnTArray1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSerch);
            this.Controls.Add(this.BtnSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnArrayEven);
            this.Controls.Add(this.LabView);
            this.Controls.Add(this.LabResult);
            this.Controls.Add(this.BtnEven);
            this.Controls.Add(this.TxbEven);
            this.Name = "Method";
            this.Text = "方法";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbEven;
        private System.Windows.Forms.Button BtnEven;
        private System.Windows.Forms.Label LabResult;
        private System.Windows.Forms.Label LabView;
        private System.Windows.Forms.Button BtnArrayEven;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSize;
        private System.Windows.Forms.Button BtnSerch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnTArray1;
        private System.Windows.Forms.Button BtnTArray2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSwap;
        private System.Windows.Forms.Button BtnArraySum;
        private System.Windows.Forms.Button BtnBinary;
        private System.Windows.Forms.TextBox TxbCal;
        private System.Windows.Forms.Button BtnFor;
        private System.Windows.Forms.Button BtnMtable;
        private System.Windows.Forms.Button BtnBingo;
    }
}