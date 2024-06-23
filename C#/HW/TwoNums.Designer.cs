
namespace HW
{
    partial class TwoNums
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
            this.LabNum1 = new System.Windows.Forms.Label();
            this.LabNum2 = new System.Windows.Forms.Label();
            this.TxbNum1 = new System.Windows.Forms.TextBox();
            this.TxbNum2 = new System.Windows.Forms.TextBox();
            this.LabAnswer = new System.Windows.Forms.Label();
            this.TxbAnswer = new System.Windows.Forms.TextBox();
            this.BtnP = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnTimes = new System.Windows.Forms.Button();
            this.BtnDivided = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabNum1
            // 
            this.LabNum1.AutoSize = true;
            this.LabNum1.BackColor = System.Drawing.Color.Transparent;
            this.LabNum1.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabNum1.Location = new System.Drawing.Point(26, 42);
            this.LabNum1.Name = "LabNum1";
            this.LabNum1.Size = new System.Drawing.Size(56, 20);
            this.LabNum1.TabIndex = 0;
            this.LabNum1.Text = "Num1";
            // 
            // LabNum2
            // 
            this.LabNum2.AutoSize = true;
            this.LabNum2.BackColor = System.Drawing.Color.Transparent;
            this.LabNum2.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabNum2.Location = new System.Drawing.Point(26, 77);
            this.LabNum2.Name = "LabNum2";
            this.LabNum2.Size = new System.Drawing.Size(56, 20);
            this.LabNum2.TabIndex = 1;
            this.LabNum2.Text = "Num2";
            // 
            // TxbNum1
            // 
            this.TxbNum1.Location = new System.Drawing.Point(88, 42);
            this.TxbNum1.Name = "TxbNum1";
            this.TxbNum1.Size = new System.Drawing.Size(100, 22);
            this.TxbNum1.TabIndex = 2;
            // 
            // TxbNum2
            // 
            this.TxbNum2.Location = new System.Drawing.Point(88, 75);
            this.TxbNum2.Name = "TxbNum2";
            this.TxbNum2.Size = new System.Drawing.Size(100, 22);
            this.TxbNum2.TabIndex = 3;
            // 
            // LabAnswer
            // 
            this.LabAnswer.AutoSize = true;
            this.LabAnswer.BackColor = System.Drawing.Color.Transparent;
            this.LabAnswer.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabAnswer.Location = new System.Drawing.Point(14, 142);
            this.LabAnswer.Name = "LabAnswer";
            this.LabAnswer.Size = new System.Drawing.Size(67, 20);
            this.LabAnswer.TabIndex = 4;
            this.LabAnswer.Text = "Answer";
            // 
            // TxbAnswer
            // 
            this.TxbAnswer.Location = new System.Drawing.Point(88, 140);
            this.TxbAnswer.Name = "TxbAnswer";
            this.TxbAnswer.Size = new System.Drawing.Size(100, 22);
            this.TxbAnswer.TabIndex = 5;
            // 
            // BtnP
            // 
            this.BtnP.Location = new System.Drawing.Point(18, 107);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(41, 27);
            this.BtnP.TabIndex = 6;
            this.BtnP.Text = "+";
            this.BtnP.UseVisualStyleBackColor = true;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(65, 107);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(41, 27);
            this.BtnMinus.TabIndex = 7;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnTimes
            // 
            this.BtnTimes.Location = new System.Drawing.Point(112, 107);
            this.BtnTimes.Name = "BtnTimes";
            this.BtnTimes.Size = new System.Drawing.Size(41, 27);
            this.BtnTimes.TabIndex = 8;
            this.BtnTimes.Text = "x";
            this.BtnTimes.UseVisualStyleBackColor = true;
            this.BtnTimes.Click += new System.EventHandler(this.BtnTimes_Click);
            // 
            // BtnDivided
            // 
            this.BtnDivided.Location = new System.Drawing.Point(159, 107);
            this.BtnDivided.Name = "BtnDivided";
            this.BtnDivided.Size = new System.Drawing.Size(41, 27);
            this.BtnDivided.TabIndex = 9;
            this.BtnDivided.Text = "/";
            this.BtnDivided.UseVisualStyleBackColor = true;
            this.BtnDivided.Click += new System.EventHandler(this.BtnDivided_Click);
            // 
            // TwoNums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW.Properties.Resources.DD_Wall_Texture_22102_DD_Wall_Texture_22102_Preview;
            this.ClientSize = new System.Drawing.Size(251, 208);
            this.Controls.Add(this.BtnDivided);
            this.Controls.Add(this.BtnTimes);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnP);
            this.Controls.Add(this.TxbAnswer);
            this.Controls.Add(this.LabAnswer);
            this.Controls.Add(this.TxbNum2);
            this.Controls.Add(this.TxbNum1);
            this.Controls.Add(this.LabNum2);
            this.Controls.Add(this.LabNum1);
            this.Name = "TwoNums";
            this.Text = "TwoNums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNum1;
        private System.Windows.Forms.Label LabNum2;
        private System.Windows.Forms.TextBox TxbNum1;
        private System.Windows.Forms.TextBox TxbNum2;
        private System.Windows.Forms.Label LabAnswer;
        private System.Windows.Forms.TextBox TxbAnswer;
        private System.Windows.Forms.Button BtnP;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnTimes;
        private System.Windows.Forms.Button BtnDivided;
    }
}