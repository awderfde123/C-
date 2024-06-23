
namespace HW
{
    partial class Homepage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Formhw = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BtnClock = new System.Windows.Forms.Button();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.BtnDrow = new System.Windows.Forms.Button();
            this.BtnNote = new System.Windows.Forms.Button();
            this.BtnScreenSave = new System.Windows.Forms.Button();
            this.BtnGame = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnMethod = new System.Windows.Forms.Button();
            this.BtnCalGrade = new System.Windows.Forms.Button();
            this.BtnGrade = new System.Windows.Forms.Button();
            this.MMenu = new System.Windows.Forms.Button();
            this.BtnInterest = new System.Windows.Forms.Button();
            this.HwName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.Formhw);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 661);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // Formhw
            // 
            this.Formhw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Formhw.AutoSize = true;
            this.Formhw.BackColor = System.Drawing.Color.Transparent;
            this.Formhw.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Formhw.Location = new System.Drawing.Point(488, 24);
            this.Formhw.Name = "Formhw";
            this.Formhw.Size = new System.Drawing.Size(96, 27);
            this.Formhw.TabIndex = 0;
            this.Formhw.Text = "C#";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackgroundImage = global::HW.Properties.Resources.未命名;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.BtnClock);
            this.splitContainer2.Panel1.Controls.Add(this.BtnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.BtnDrow);
            this.splitContainer2.Panel1.Controls.Add(this.BtnNote);
            this.splitContainer2.Panel1.Controls.Add(this.BtnScreenSave);
            this.splitContainer2.Panel1.Controls.Add(this.BtnGame);
            this.splitContainer2.Panel1.Controls.Add(this.BtnCalculate);
            this.splitContainer2.Panel1.Controls.Add(this.BtnMethod);
            this.splitContainer2.Panel1.Controls.Add(this.BtnCalGrade);
            this.splitContainer2.Panel1.Controls.Add(this.BtnGrade);
            this.splitContainer2.Panel1.Controls.Add(this.MMenu);
            this.splitContainer2.Panel1.Controls.Add(this.BtnInterest);
            this.splitContainer2.Panel1.Controls.Add(this.HwName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackgroundImage = global::HW.Properties.Resources.未命名;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(1055, 588);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.TabIndex = 0;
            // 
            // BtnClock
            // 
            this.BtnClock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnClock.Location = new System.Drawing.Point(3, 447);
            this.BtnClock.Name = "BtnClock";
            this.BtnClock.Size = new System.Drawing.Size(265, 31);
            this.BtnClock.TabIndex = 12;
            this.BtnClock.Text = "小鬧鐘";
            this.BtnClock.UseVisualStyleBackColor = true;
            this.BtnClock.Click += new System.EventHandler(this.BtnClock_Click);
            // 
            // BtnGuess
            // 
            this.BtnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuess.Location = new System.Drawing.Point(3, 410);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(265, 31);
            this.BtnGuess.TabIndex = 11;
            this.BtnGuess.Text = "猜數字";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // BtnDrow
            // 
            this.BtnDrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDrow.Location = new System.Drawing.Point(3, 373);
            this.BtnDrow.Name = "BtnDrow";
            this.BtnDrow.Size = new System.Drawing.Size(265, 31);
            this.BtnDrow.TabIndex = 10;
            this.BtnDrow.Text = "小畫板";
            this.BtnDrow.UseVisualStyleBackColor = true;
            this.BtnDrow.Click += new System.EventHandler(this.BtnDrow_Click);
            // 
            // BtnNote
            // 
            this.BtnNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNote.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNote.Location = new System.Drawing.Point(3, 336);
            this.BtnNote.Name = "BtnNote";
            this.BtnNote.Size = new System.Drawing.Size(265, 31);
            this.BtnNote.TabIndex = 9;
            this.BtnNote.Text = "筆記本";
            this.BtnNote.UseVisualStyleBackColor = true;
            this.BtnNote.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // BtnScreenSave
            // 
            this.BtnScreenSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnScreenSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnScreenSave.Location = new System.Drawing.Point(3, 299);
            this.BtnScreenSave.Name = "BtnScreenSave";
            this.BtnScreenSave.Size = new System.Drawing.Size(265, 31);
            this.BtnScreenSave.TabIndex = 8;
            this.BtnScreenSave.Text = "螢幕保護";
            this.BtnScreenSave.UseVisualStyleBackColor = true;
            this.BtnScreenSave.Click += new System.EventHandler(this.BtnScreenSave_Click);
            // 
            // BtnGame
            // 
            this.BtnGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGame.Location = new System.Drawing.Point(3, 262);
            this.BtnGame.Name = "BtnGame";
            this.BtnGame.Size = new System.Drawing.Size(265, 31);
            this.BtnGame.TabIndex = 7;
            this.BtnGame.Text = "井字遊戲";
            this.BtnGame.UseVisualStyleBackColor = true;
            this.BtnGame.Click += new System.EventHandler(this.BtnGame_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCalculate.Location = new System.Drawing.Point(3, 225);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(265, 31);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "兩數運算";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnMethod
            // 
            this.BtnMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMethod.Location = new System.Drawing.Point(3, 188);
            this.BtnMethod.Name = "BtnMethod";
            this.BtnMethod.Size = new System.Drawing.Size(265, 31);
            this.BtnMethod.TabIndex = 5;
            this.BtnMethod.Text = "方法";
            this.BtnMethod.UseVisualStyleBackColor = true;
            this.BtnMethod.Click += new System.EventHandler(this.BtnMethod_Click);
            // 
            // BtnCalGrade
            // 
            this.BtnCalGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalGrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCalGrade.Location = new System.Drawing.Point(3, 151);
            this.BtnCalGrade.Name = "BtnCalGrade";
            this.BtnCalGrade.Size = new System.Drawing.Size(265, 31);
            this.BtnCalGrade.TabIndex = 4;
            this.BtnCalGrade.Text = "計算成績";
            this.BtnCalGrade.UseVisualStyleBackColor = true;
            this.BtnCalGrade.Click += new System.EventHandler(this.BtnCalGrade_Click);
            // 
            // BtnGrade
            // 
            this.BtnGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGrade.Location = new System.Drawing.Point(3, 114);
            this.BtnGrade.Name = "BtnGrade";
            this.BtnGrade.Size = new System.Drawing.Size(265, 31);
            this.BtnGrade.TabIndex = 3;
            this.BtnGrade.Text = "成績";
            this.BtnGrade.UseVisualStyleBackColor = true;
            this.BtnGrade.Click += new System.EventHandler(this.BtnGrade_Click);
            // 
            // MMenu
            // 
            this.MMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MMenu.Location = new System.Drawing.Point(3, 77);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(265, 31);
            this.MMenu.TabIndex = 2;
            this.MMenu.Text = "菜單";
            this.MMenu.UseVisualStyleBackColor = true;
            this.MMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // BtnInterest
            // 
            this.BtnInterest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInterest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnInterest.Location = new System.Drawing.Point(3, 40);
            this.BtnInterest.Name = "BtnInterest";
            this.BtnInterest.Size = new System.Drawing.Size(265, 31);
            this.BtnInterest.TabIndex = 1;
            this.BtnInterest.Text = "本金平均攤還法";
            this.BtnInterest.UseVisualStyleBackColor = true;
            this.BtnInterest.Click += new System.EventHandler(this.BtnInterest_Click);
            // 
            // HwName
            // 
            this.HwName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HwName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HwName.Location = new System.Drawing.Point(3, 3);
            this.HwName.Name = "HwName";
            this.HwName.Size = new System.Drawing.Size(265, 31);
            this.HwName.TabIndex = 0;
            this.HwName.Text = "名字";
            this.HwName.UseVisualStyleBackColor = true;
            this.HwName.Click += new System.EventHandler(this.HwName_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 661);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Homepage";
            this.Text = "首頁";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label Formhw;
        private System.Windows.Forms.Button HwName;
        private System.Windows.Forms.Button BtnInterest;
        private System.Windows.Forms.Button MMenu;
        private System.Windows.Forms.Button BtnGrade;
        private System.Windows.Forms.Button BtnCalGrade;
        private System.Windows.Forms.Button BtnMethod;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnGame;
        private System.Windows.Forms.Button BtnScreenSave;
        private System.Windows.Forms.Button BtnNote;
        private System.Windows.Forms.Button BtnDrow;
        private System.Windows.Forms.Button BtnClock;
        private System.Windows.Forms.Button BtnGuess;
    }
}

