
namespace HW
{
    partial class GuessAnswer
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
            this.LabAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabAnswer
            // 
            this.LabAnswer.Font = new System.Drawing.Font("新細明體", 30F);
            this.LabAnswer.Location = new System.Drawing.Point(93, 19);
            this.LabAnswer.Name = "LabAnswer";
            this.LabAnswer.Size = new System.Drawing.Size(136, 51);
            this.LabAnswer.TabIndex = 0;
            // 
            // GuessAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 79);
            this.Controls.Add(this.LabAnswer);
            this.Name = "GuessAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正確答案";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabAnswer;
    }
}