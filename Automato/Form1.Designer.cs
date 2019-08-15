namespace Automato
{
    partial class Form1
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
            this.chkRule0 = new System.Windows.Forms.CheckBox();
            this.chkRule1 = new System.Windows.Forms.CheckBox();
            this.chkRule2 = new System.Windows.Forms.CheckBox();
            this.chkRule3 = new System.Windows.Forms.CheckBox();
            this.chkRule4 = new System.Windows.Forms.CheckBox();
            this.chkRule5 = new System.Windows.Forms.CheckBox();
            this.chkRule6 = new System.Windows.Forms.CheckBox();
            this.chkRule7 = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkRule0
            // 
            this.chkRule0.AutoSize = true;
            this.chkRule0.Location = new System.Drawing.Point(12, 12);
            this.chkRule0.Name = "chkRule0";
            this.chkRule0.Size = new System.Drawing.Size(54, 21);
            this.chkRule0.TabIndex = 0;
            this.chkRule0.Tag = "0";
            this.chkRule0.Text = "000";
            this.chkRule0.UseVisualStyleBackColor = true;
            this.chkRule0.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule1
            // 
            this.chkRule1.AutoSize = true;
            this.chkRule1.Location = new System.Drawing.Point(72, 12);
            this.chkRule1.Name = "chkRule1";
            this.chkRule1.Size = new System.Drawing.Size(54, 21);
            this.chkRule1.TabIndex = 1;
            this.chkRule1.Tag = "1";
            this.chkRule1.Text = "001";
            this.chkRule1.UseVisualStyleBackColor = true;
            this.chkRule1.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule2
            // 
            this.chkRule2.AutoSize = true;
            this.chkRule2.Location = new System.Drawing.Point(132, 12);
            this.chkRule2.Name = "chkRule2";
            this.chkRule2.Size = new System.Drawing.Size(54, 21);
            this.chkRule2.TabIndex = 2;
            this.chkRule2.Tag = "2";
            this.chkRule2.Text = "010";
            this.chkRule2.UseVisualStyleBackColor = true;
            this.chkRule2.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule3
            // 
            this.chkRule3.AutoSize = true;
            this.chkRule3.Location = new System.Drawing.Point(192, 12);
            this.chkRule3.Name = "chkRule3";
            this.chkRule3.Size = new System.Drawing.Size(54, 21);
            this.chkRule3.TabIndex = 3;
            this.chkRule3.Tag = "3";
            this.chkRule3.Text = "011";
            this.chkRule3.UseVisualStyleBackColor = true;
            this.chkRule3.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule4
            // 
            this.chkRule4.AutoSize = true;
            this.chkRule4.Location = new System.Drawing.Point(252, 12);
            this.chkRule4.Name = "chkRule4";
            this.chkRule4.Size = new System.Drawing.Size(54, 21);
            this.chkRule4.TabIndex = 4;
            this.chkRule4.Tag = "4";
            this.chkRule4.Text = "100";
            this.chkRule4.UseVisualStyleBackColor = true;
            this.chkRule4.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule5
            // 
            this.chkRule5.AutoSize = true;
            this.chkRule5.Location = new System.Drawing.Point(312, 12);
            this.chkRule5.Name = "chkRule5";
            this.chkRule5.Size = new System.Drawing.Size(54, 21);
            this.chkRule5.TabIndex = 5;
            this.chkRule5.Tag = "5";
            this.chkRule5.Text = "101";
            this.chkRule5.UseVisualStyleBackColor = true;
            this.chkRule5.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule6
            // 
            this.chkRule6.AutoSize = true;
            this.chkRule6.Location = new System.Drawing.Point(372, 12);
            this.chkRule6.Name = "chkRule6";
            this.chkRule6.Size = new System.Drawing.Size(54, 21);
            this.chkRule6.TabIndex = 6;
            this.chkRule6.Tag = "6";
            this.chkRule6.Text = "110";
            this.chkRule6.UseVisualStyleBackColor = true;
            this.chkRule6.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // chkRule7
            // 
            this.chkRule7.AutoSize = true;
            this.chkRule7.Location = new System.Drawing.Point(432, 12);
            this.chkRule7.Name = "chkRule7";
            this.chkRule7.Size = new System.Drawing.Size(54, 21);
            this.chkRule7.TabIndex = 7;
            this.chkRule7.Tag = "7";
            this.chkRule7.Text = "111";
            this.chkRule7.UseVisualStyleBackColor = true;
            this.chkRule7.CheckedChanged += new System.EventHandler(this.ChkRules_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(492, 10);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 1053);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.chkRule7);
            this.Controls.Add(this.chkRule6);
            this.Controls.Add(this.chkRule5);
            this.Controls.Add(this.chkRule4);
            this.Controls.Add(this.chkRule3);
            this.Controls.Add(this.chkRule2);
            this.Controls.Add(this.chkRule1);
            this.Controls.Add(this.chkRule0);
            this.Name = "Form1";
            this.Text = "Automata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRule0;
        private System.Windows.Forms.CheckBox chkRule1;
        private System.Windows.Forms.CheckBox chkRule2;
        private System.Windows.Forms.CheckBox chkRule3;
        private System.Windows.Forms.CheckBox chkRule4;
        private System.Windows.Forms.CheckBox chkRule5;
        private System.Windows.Forms.CheckBox chkRule6;
        private System.Windows.Forms.CheckBox chkRule7;
        private System.Windows.Forms.Button btnRun;
    }
}

