
namespace HW
{
    partial class GuessGame
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
            this.LabGuess = new System.Windows.Forms.Label();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabGuess
            // 
            this.LabGuess.AutoSize = true;
            this.LabGuess.BackColor = System.Drawing.Color.Transparent;
            this.LabGuess.Font = new System.Drawing.Font("新細明體", 40F);
            this.LabGuess.Location = new System.Drawing.Point(29, 26);
            this.LabGuess.Name = "LabGuess";
            this.LabGuess.Size = new System.Drawing.Size(326, 54);
            this.LabGuess.TabIndex = 0;
            this.LabGuess.Text = "0~100 猜數字";
            // 
            // BtnGuess
            // 
            this.BtnGuess.Location = new System.Drawing.Point(38, 261);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(132, 62);
            this.BtnGuess.TabIndex = 1;
            this.BtnGuess.Text = "猜數字";
            this.BtnGuess.UseVisualStyleBackColor = true;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(216, 261);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(132, 62);
            this.BtnAnswer.TabIndex = 2;
            this.BtnAnswer.Text = "正確答案";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // GuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW.Properties.Resources.DD_Wall_Texture_22102_DD_Wall_Texture_22102_Preview;
            this.ClientSize = new System.Drawing.Size(393, 339);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.LabGuess);
            this.Name = "GuessGame";
            this.Text = "猜數字遊戲";
            this.Load += new System.EventHandler(this.GuessGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabGuess;
        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.Button BtnAnswer;
    }
}