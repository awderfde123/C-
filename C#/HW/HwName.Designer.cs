
namespace HW
{
    partial class HwName
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
            this.CName = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Constellation = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbEName = new System.Windows.Forms.TextBox();
            this.TxbGender = new System.Windows.Forms.TextBox();
            this.TxbConstellation = new System.Windows.Forms.TextBox();
            this.SayHi = new System.Windows.Forms.Button();
            this.SayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.BackColor = System.Drawing.Color.Transparent;
            this.CName.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CName.Location = new System.Drawing.Point(47, 36);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(117, 40);
            this.CName.TabIndex = 0;
            this.CName.Text = "姓名 :";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.BackColor = System.Drawing.Color.Transparent;
            this.EName.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EName.Location = new System.Drawing.Point(47, 92);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(252, 40);
            this.EName.TabIndex = 1;
            this.EName.Text = "English Name :";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gender.Location = new System.Drawing.Point(47, 149);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(117, 40);
            this.Gender.TabIndex = 2;
            this.Gender.Text = "性別 :";
            // 
            // Constellation
            // 
            this.Constellation.AutoSize = true;
            this.Constellation.BackColor = System.Drawing.Color.Transparent;
            this.Constellation.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Constellation.Location = new System.Drawing.Point(47, 203);
            this.Constellation.Name = "Constellation";
            this.Constellation.Size = new System.Drawing.Size(117, 40);
            this.Constellation.TabIndex = 3;
            this.Constellation.Text = "星座 :";
            // 
            // TxbName
            // 
            this.TxbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbName.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxbName.Location = new System.Drawing.Point(305, 36);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(306, 32);
            this.TxbName.TabIndex = 4;
            this.TxbName.TextChanged += new System.EventHandler(this.TxbName_TextChanged);
            // 
            // TxbEName
            // 
            this.TxbEName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbEName.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxbEName.Location = new System.Drawing.Point(305, 93);
            this.TxbEName.Name = "TxbEName";
            this.TxbEName.Size = new System.Drawing.Size(306, 32);
            this.TxbEName.TabIndex = 5;
            // 
            // TxbGender
            // 
            this.TxbGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbGender.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxbGender.Location = new System.Drawing.Point(305, 149);
            this.TxbGender.Name = "TxbGender";
            this.TxbGender.Size = new System.Drawing.Size(306, 32);
            this.TxbGender.TabIndex = 6;
            // 
            // TxbConstellation
            // 
            this.TxbConstellation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbConstellation.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxbConstellation.Location = new System.Drawing.Point(305, 203);
            this.TxbConstellation.Name = "TxbConstellation";
            this.TxbConstellation.Size = new System.Drawing.Size(306, 32);
            this.TxbConstellation.TabIndex = 7;
            // 
            // SayHi
            // 
            this.SayHi.BackColor = System.Drawing.Color.Silver;
            this.SayHi.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SayHi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SayHi.Location = new System.Drawing.Point(54, 273);
            this.SayHi.Name = "SayHi";
            this.SayHi.Size = new System.Drawing.Size(268, 120);
            this.SayHi.TabIndex = 8;
            this.SayHi.Text = "HI~~~~";
            this.SayHi.UseVisualStyleBackColor = false;
            this.SayHi.Click += new System.EventHandler(this.SayHi_Click);
            // 
            // SayHello
            // 
            this.SayHello.BackColor = System.Drawing.Color.Silver;
            this.SayHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SayHello.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SayHello.Location = new System.Drawing.Point(328, 273);
            this.SayHello.Name = "SayHello";
            this.SayHello.Size = new System.Drawing.Size(283, 120);
            this.SayHello.TabIndex = 9;
            this.SayHello.Text = "HELLO~~~~";
            this.SayHello.UseVisualStyleBackColor = false;
            this.SayHello.Click += new System.EventHandler(this.SayHello_Click);
            // 
            // HwName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW.Properties.Resources.DD_Wall_Texture_22102_DD_Wall_Texture_22102_Preview;
            this.ClientSize = new System.Drawing.Size(668, 429);
            this.Controls.Add(this.SayHello);
            this.Controls.Add(this.SayHi);
            this.Controls.Add(this.TxbConstellation);
            this.Controls.Add(this.TxbGender);
            this.Controls.Add(this.TxbEName);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.Constellation);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.CName);
            this.Name = "HwName";
            this.Text = "打招呼";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Constellation;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.TextBox TxbEName;
        private System.Windows.Forms.TextBox TxbGender;
        private System.Windows.Forms.TextBox TxbConstellation;
        private System.Windows.Forms.Button SayHi;
        private System.Windows.Forms.Button SayHello;
    }
}