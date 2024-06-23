
namespace HW
{
    partial class Grade
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
            this.LabName = new System.Windows.Forms.Label();
            this.LabChinese = new System.Windows.Forms.Label();
            this.LabEnglish = new System.Windows.Forms.Label();
            this.LabMath = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbChinese = new System.Windows.Forms.TextBox();
            this.TxbEnglish = new System.Windows.Forms.TextBox();
            this.TxbMath = new System.Windows.Forms.TextBox();
            this.PFrame = new System.Windows.Forms.Panel();
            this.LabShow2 = new System.Windows.Forms.Label();
            this.LabShow1 = new System.Windows.Forms.Label();
            this.LabFrame = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnHF = new System.Windows.Forms.Button();
            this.PFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabName.Location = new System.Drawing.Point(28, 28);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(66, 27);
            this.LabName.TabIndex = 0;
            this.LabName.Text = "姓名";
            // 
            // LabChinese
            // 
            this.LabChinese.AutoSize = true;
            this.LabChinese.BackColor = System.Drawing.Color.Transparent;
            this.LabChinese.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabChinese.Location = new System.Drawing.Point(28, 66);
            this.LabChinese.Name = "LabChinese";
            this.LabChinese.Size = new System.Drawing.Size(66, 27);
            this.LabChinese.TabIndex = 1;
            this.LabChinese.Text = "國文";
            // 
            // LabEnglish
            // 
            this.LabEnglish.AutoSize = true;
            this.LabEnglish.BackColor = System.Drawing.Color.Transparent;
            this.LabEnglish.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabEnglish.Location = new System.Drawing.Point(28, 106);
            this.LabEnglish.Name = "LabEnglish";
            this.LabEnglish.Size = new System.Drawing.Size(66, 27);
            this.LabEnglish.TabIndex = 2;
            this.LabEnglish.Text = "英文";
            // 
            // LabMath
            // 
            this.LabMath.AutoSize = true;
            this.LabMath.BackColor = System.Drawing.Color.Transparent;
            this.LabMath.Font = new System.Drawing.Font("新細明體", 20F);
            this.LabMath.Location = new System.Drawing.Point(28, 143);
            this.LabMath.Name = "LabMath";
            this.LabMath.Size = new System.Drawing.Size(66, 27);
            this.LabMath.TabIndex = 3;
            this.LabMath.Text = "數學";
            // 
            // TxbName
            // 
            this.TxbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbName.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxbName.Location = new System.Drawing.Point(111, 28);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(100, 27);
            this.TxbName.TabIndex = 4;
            this.TxbName.TextChanged += new System.EventHandler(this.TxbName_TextChanged);
            // 
            // TxbChinese
            // 
            this.TxbChinese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbChinese.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxbChinese.Location = new System.Drawing.Point(111, 66);
            this.TxbChinese.Name = "TxbChinese";
            this.TxbChinese.Size = new System.Drawing.Size(100, 27);
            this.TxbChinese.TabIndex = 5;
            // 
            // TxbEnglish
            // 
            this.TxbEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbEnglish.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxbEnglish.Location = new System.Drawing.Point(111, 106);
            this.TxbEnglish.Name = "TxbEnglish";
            this.TxbEnglish.Size = new System.Drawing.Size(100, 27);
            this.TxbEnglish.TabIndex = 6;
            // 
            // TxbMath
            // 
            this.TxbMath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbMath.Font = new System.Drawing.Font("新細明體", 12F);
            this.TxbMath.Location = new System.Drawing.Point(111, 143);
            this.TxbMath.Name = "TxbMath";
            this.TxbMath.Size = new System.Drawing.Size(100, 27);
            this.TxbMath.TabIndex = 7;
            // 
            // PFrame
            // 
            this.PFrame.BackColor = System.Drawing.Color.Transparent;
            this.PFrame.Controls.Add(this.LabShow2);
            this.PFrame.Controls.Add(this.LabShow1);
            this.PFrame.Location = new System.Drawing.Point(234, 28);
            this.PFrame.Name = "PFrame";
            this.PFrame.Size = new System.Drawing.Size(245, 254);
            this.PFrame.TabIndex = 9;
            // 
            // LabShow2
            // 
            this.LabShow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabShow2.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabShow2.Location = new System.Drawing.Point(3, 145);
            this.LabShow2.Name = "LabShow2";
            this.LabShow2.Size = new System.Drawing.Size(239, 105);
            this.LabShow2.TabIndex = 1;
            // 
            // LabShow1
            // 
            this.LabShow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabShow1.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabShow1.Location = new System.Drawing.Point(3, 12);
            this.LabShow1.Name = "LabShow1";
            this.LabShow1.Size = new System.Drawing.Size(239, 130);
            this.LabShow1.TabIndex = 0;
            this.LabShow1.Click += new System.EventHandler(this.LabShow1_Click);
            // 
            // LabFrame
            // 
            this.LabFrame.AutoSize = true;
            this.LabFrame.BackColor = System.Drawing.Color.Transparent;
            this.LabFrame.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabFrame.Location = new System.Drawing.Point(260, 20);
            this.LabFrame.Name = "LabFrame";
            this.LabFrame.Size = new System.Drawing.Size(49, 20);
            this.LabFrame.TabIndex = 0;
            this.LabFrame.Text = "成績";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(33, 174);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(178, 36);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "儲存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(33, 216);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(178, 26);
            this.BtnShow.TabIndex = 11;
            this.BtnShow.Text = "顯示儲存";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnHF
            // 
            this.BtnHF.Location = new System.Drawing.Point(33, 246);
            this.BtnHF.Name = "BtnHF";
            this.BtnHF.Size = new System.Drawing.Size(178, 36);
            this.BtnHF.TabIndex = 12;
            this.BtnHF.Text = "最高分/最低分科目";
            this.BtnHF.UseVisualStyleBackColor = true;
            this.BtnHF.Click += new System.EventHandler(this.BtnHF_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW.Properties.Resources.DD_Wall_Texture_22102_DD_Wall_Texture_22102_Preview;
            this.ClientSize = new System.Drawing.Size(501, 299);
            this.Controls.Add(this.BtnHF);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LabFrame);
            this.Controls.Add(this.PFrame);
            this.Controls.Add(this.TxbMath);
            this.Controls.Add(this.TxbEnglish);
            this.Controls.Add(this.TxbChinese);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.LabMath);
            this.Controls.Add(this.LabEnglish);
            this.Controls.Add(this.LabChinese);
            this.Controls.Add(this.LabName);
            this.Name = "Grade";
            this.Text = "成績";
            this.Load += new System.EventHandler(this.Grade_Load);
            this.PFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Label LabChinese;
        private System.Windows.Forms.Label LabEnglish;
        private System.Windows.Forms.Label LabMath;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.TextBox TxbChinese;
        private System.Windows.Forms.TextBox TxbEnglish;
        private System.Windows.Forms.TextBox TxbMath;
        private System.Windows.Forms.Panel PFrame;
        private System.Windows.Forms.Label LabShow2;
        private System.Windows.Forms.Label LabShow1;
        private System.Windows.Forms.Label LabFrame;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnHF;
    }
}