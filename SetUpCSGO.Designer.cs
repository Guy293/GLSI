namespace GLSI
{
    partial class SetUpCSGO
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
            this.button1 = new System.Windows.Forms.Button();
            this.KillsCounterCheckBox = new System.Windows.Forms.CheckBox();
            this.DeathCounterCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set Up\r\nConfig file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KillsCounterCheckBox
            // 
            this.KillsCounterCheckBox.AutoSize = true;
            this.KillsCounterCheckBox.Location = new System.Drawing.Point(13, 61);
            this.KillsCounterCheckBox.Name = "KillsCounterCheckBox";
            this.KillsCounterCheckBox.Size = new System.Drawing.Size(84, 17);
            this.KillsCounterCheckBox.TabIndex = 1;
            this.KillsCounterCheckBox.Text = "Kills Counter";
            this.KillsCounterCheckBox.UseVisualStyleBackColor = true;
            this.KillsCounterCheckBox.CheckedChanged += new System.EventHandler(this.KillsCounterCheckBox_CheckedChanged);
            // 
            // DeathCounterCheckBox
            // 
            this.DeathCounterCheckBox.AutoSize = true;
            this.DeathCounterCheckBox.Location = new System.Drawing.Point(12, 84);
            this.DeathCounterCheckBox.Name = "DeathCounterCheckBox";
            this.DeathCounterCheckBox.Size = new System.Drawing.Size(95, 17);
            this.DeathCounterCheckBox.TabIndex = 2;
            this.DeathCounterCheckBox.Text = "Death Counter";
            this.DeathCounterCheckBox.UseVisualStyleBackColor = true;
            this.DeathCounterCheckBox.CheckedChanged += new System.EventHandler(this.DeathCounterCheckBox_CheckedChanged);
            // 
            // SetUpCSGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 230);
            this.Controls.Add(this.DeathCounterCheckBox);
            this.Controls.Add(this.KillsCounterCheckBox);
            this.Controls.Add(this.button1);
            this.Name = "SetUpCSGO";
            this.Text = "SetUpCSGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox KillsCounterCheckBox;
        private System.Windows.Forms.CheckBox DeathCounterCheckBox;
    }
}