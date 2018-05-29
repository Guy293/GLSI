namespace GLSI
{
    partial class Main
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
            this.StartCsgoBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.AssistsCounterTXTCheckBox = new System.Windows.Forms.CheckBox();
            this.DeathsCounterTXTCheckBox = new System.Windows.Forms.CheckBox();
            this.KillsCounterTXTCheckBox = new System.Windows.Forms.CheckBox();
            this.setUpCsgoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartCsgoBtn
            // 
            this.StartCsgoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StartCsgoBtn.Location = new System.Drawing.Point(26, 12);
            this.StartCsgoBtn.Name = "StartCsgoBtn";
            this.StartCsgoBtn.Size = new System.Drawing.Size(81, 42);
            this.StartCsgoBtn.TabIndex = 2;
            this.StartCsgoBtn.Text = "Start";
            this.StartCsgoBtn.UseVisualStyleBackColor = true;
            this.StartCsgoBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AssistsCounterTXTCheckBox
            // 
            this.AssistsCounterTXTCheckBox.AutoSize = true;
            this.AssistsCounterTXTCheckBox.Location = new System.Drawing.Point(10, 146);
            this.AssistsCounterTXTCheckBox.Name = "AssistsCounterTXTCheckBox";
            this.AssistsCounterTXTCheckBox.Size = new System.Drawing.Size(122, 17);
            this.AssistsCounterTXTCheckBox.TabIndex = 7;
            this.AssistsCounterTXTCheckBox.Text = "Assists Counter Text";
            this.AssistsCounterTXTCheckBox.UseVisualStyleBackColor = true;
            this.AssistsCounterTXTCheckBox.CheckedChanged += new System.EventHandler(this.AssistsCounterCheckBox_CheckedChanged);
            // 
            // DeathsCounterTXTCheckBox
            // 
            this.DeathsCounterTXTCheckBox.AutoSize = true;
            this.DeathsCounterTXTCheckBox.Location = new System.Drawing.Point(10, 125);
            this.DeathsCounterTXTCheckBox.Name = "DeathsCounterTXTCheckBox";
            this.DeathsCounterTXTCheckBox.Size = new System.Drawing.Size(124, 17);
            this.DeathsCounterTXTCheckBox.TabIndex = 6;
            this.DeathsCounterTXTCheckBox.Text = "Deaths Counter Text";
            this.DeathsCounterTXTCheckBox.UseVisualStyleBackColor = true;
            this.DeathsCounterTXTCheckBox.CheckedChanged += new System.EventHandler(this.DeathsCounterCheckBox_CheckedChanged);
            // 
            // KillsCounterTXTCheckBox
            // 
            this.KillsCounterTXTCheckBox.AutoSize = true;
            this.KillsCounterTXTCheckBox.Location = new System.Drawing.Point(10, 104);
            this.KillsCounterTXTCheckBox.Name = "KillsCounterTXTCheckBox";
            this.KillsCounterTXTCheckBox.Size = new System.Drawing.Size(108, 17);
            this.KillsCounterTXTCheckBox.TabIndex = 5;
            this.KillsCounterTXTCheckBox.Text = "Kills Counter Text";
            this.KillsCounterTXTCheckBox.UseVisualStyleBackColor = true;
            this.KillsCounterTXTCheckBox.CheckedChanged += new System.EventHandler(this.KillsCounterCheckBox_CheckedChanged_1);
            // 
            // setUpCsgoBtn
            // 
            this.setUpCsgoBtn.Location = new System.Drawing.Point(23, 58);
            this.setUpCsgoBtn.Name = "setUpCsgoBtn";
            this.setUpCsgoBtn.Size = new System.Drawing.Size(87, 42);
            this.setUpCsgoBtn.TabIndex = 4;
            this.setUpCsgoBtn.Text = "Set Up\r\nConfig file";
            this.setUpCsgoBtn.UseVisualStyleBackColor = true;
            this.setUpCsgoBtn.Click += new System.EventHandler(this.setUpCsgoBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 176);
            this.Controls.Add(this.AssistsCounterTXTCheckBox);
            this.Controls.Add(this.DeathsCounterTXTCheckBox);
            this.Controls.Add(this.KillsCounterTXTCheckBox);
            this.Controls.Add(this.setUpCsgoBtn);
            this.Controls.Add(this.StartCsgoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "GLSI";
            this.Closed += new System.EventHandler(this.Main_Closed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartCsgoBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox AssistsCounterTXTCheckBox;
        private System.Windows.Forms.CheckBox DeathsCounterTXTCheckBox;
        private System.Windows.Forms.CheckBox KillsCounterTXTCheckBox;
        private System.Windows.Forms.Button setUpCsgoBtn;
    }
}