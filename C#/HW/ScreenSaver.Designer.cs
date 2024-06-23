
namespace HW
{
    partial class ScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.PtbMove = new System.Windows.Forms.PictureBox();
            this.TimerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbMove)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbMove
            // 
            this.PtbMove.BackgroundImage = global::HW.Properties.Resources.未命名11;
            this.PtbMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtbMove.Location = new System.Drawing.Point(481, 22);
            this.PtbMove.Name = "PtbMove";
            this.PtbMove.Size = new System.Drawing.Size(225, 170);
            this.PtbMove.TabIndex = 0;
            this.PtbMove.TabStop = false;
            this.PtbMove.Click += new System.EventHandler(this.PtbMove_Click);
            // 
            // TimerMove
            // 
            this.TimerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.PtbMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaver";
            this.ShowInTaskbar = false;
            this.Text = "螢幕保護";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScreenSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbMove;
        private System.Windows.Forms.Timer TimerMove;
    }
}