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
            this.SetupCsgoButton = new System.Windows.Forms.Button();
            this.EnableCsgoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SetupCsgoButton
            // 
            this.SetupCsgoButton.BackColor = System.Drawing.Color.White;
            this.SetupCsgoButton.Location = new System.Drawing.Point(14, 52);
            this.SetupCsgoButton.Name = "SetupCsgoButton";
            this.SetupCsgoButton.Size = new System.Drawing.Size(84, 49);
            this.SetupCsgoButton.TabIndex = 0;
            this.SetupCsgoButton.Text = "Set Up\r\nCS:GO";
            this.SetupCsgoButton.UseVisualStyleBackColor = false;
            this.SetupCsgoButton.Visible = false;
            this.SetupCsgoButton.Click += new System.EventHandler(this.SetupCsgoButton_Click);
            // 
            // EnableCsgoCheckBox
            // 
            this.EnableCsgoCheckBox.AutoSize = true;
            this.EnableCsgoCheckBox.Location = new System.Drawing.Point(12, 29);
            this.EnableCsgoCheckBox.Name = "EnableCsgoCheckBox";
            this.EnableCsgoCheckBox.Size = new System.Drawing.Size(86, 17);
            this.EnableCsgoCheckBox.TabIndex = 1;
            this.EnableCsgoCheckBox.Text = "Enable Csgo";
            this.EnableCsgoCheckBox.UseVisualStyleBackColor = true;
            this.EnableCsgoCheckBox.CheckedChanged += new System.EventHandler(this.EnableCsgoCheckBox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 417);
            this.Controls.Add(this.EnableCsgoCheckBox);
            this.Controls.Add(this.SetupCsgoButton);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetupCsgoButton;
        private System.Windows.Forms.CheckBox EnableCsgoCheckBox;
    }
}