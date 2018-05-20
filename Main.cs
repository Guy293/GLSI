using System;
using System.Windows.Forms;

namespace GLSI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void EnableCsgoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetupCsgoButton.Visible = EnableCsgoCheckBox.Checked;
        }

        private void SetupCsgoButton_Click(object sender, EventArgs e)
        {
            new SetUpCSGO().Show();
        }
    }
}
