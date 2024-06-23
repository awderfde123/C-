
namespace HW
{
    partial class Drow
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
            this.BtnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LabColorView = new System.Windows.Forms.Label();
            this.TkbWidth = new System.Windows.Forms.TrackBar();
            this.LabWidth = new System.Windows.Forms.Label();
            this.BtnEraser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TkbWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.Color.LightGray;
            this.BtnColor.Location = new System.Drawing.Point(738, 12);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(88, 34);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.Text = "顏色";
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // LabColorView
            // 
            this.LabColorView.BackColor = System.Drawing.Color.Black;
            this.LabColorView.Location = new System.Drawing.Point(738, 53);
            this.LabColorView.Name = "LabColorView";
            this.LabColorView.Size = new System.Drawing.Size(88, 42);
            this.LabColorView.TabIndex = 1;
            // 
            // TkbWidth
            // 
            this.TkbWidth.Location = new System.Drawing.Point(761, 98);
            this.TkbWidth.Maximum = 100;
            this.TkbWidth.Minimum = 1;
            this.TkbWidth.Name = "TkbWidth";
            this.TkbWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TkbWidth.Size = new System.Drawing.Size(45, 193);
            this.TkbWidth.TabIndex = 2;
            this.TkbWidth.TickFrequency = 5;
            this.TkbWidth.Value = 1;
            this.TkbWidth.Scroll += new System.EventHandler(this.TkbWidth_Scroll);
            // 
            // LabWidth
            // 
            this.LabWidth.BackColor = System.Drawing.Color.Transparent;
            this.LabWidth.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabWidth.Location = new System.Drawing.Point(759, 294);
            this.LabWidth.Name = "LabWidth";
            this.LabWidth.Size = new System.Drawing.Size(47, 21);
            this.LabWidth.TabIndex = 3;
            this.LabWidth.Text = "1";
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackColor = System.Drawing.Color.LightGray;
            this.BtnEraser.Location = new System.Drawing.Point(738, 493);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(88, 34);
            this.BtnEraser.TabIndex = 4;
            this.BtnEraser.Text = "橡皮擦";
            this.BtnEraser.UseVisualStyleBackColor = false;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // Drow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(838, 539);
            this.Controls.Add(this.BtnEraser);
            this.Controls.Add(this.LabWidth);
            this.Controls.Add(this.TkbWidth);
            this.Controls.Add(this.LabColorView);
            this.Controls.Add(this.BtnColor);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Drow";
            this.Text = "小畫板";
            this.Load += new System.EventHandler(this.Drow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drow_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.TkbWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LabColorView;
        private System.Windows.Forms.TrackBar TkbWidth;
        private System.Windows.Forms.Label LabWidth;
        private System.Windows.Forms.Button BtnEraser;
    }
}