using System;
using System.IO;
using System.Windows.Forms;

namespace GLSI
{
    public partial class SetUpCSGO : Form
    {
        string CsgoCfgPath = ":\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\cfg\\gamestate_integration_consolesample.cfg";
        private string LocalCfgPath = "D:\\VisualStudioProjects\\GLSI\\gamestate_integration_GLSI.cfg";
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public SetUpCSGO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\"))
            {
                File.WriteAllText("D" + CsgoCfgPath, LocalCfgPath);
            }

            else if (File.Exists("C:\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\"))
            {
                File.WriteAllText("C" + CsgoCfgPath, LocalCfgPath);
            }
            else
            {
                MessageBox.Show(
                    "Cant Find CSGO Path. Please go to where your steam library is located: \\Counter-Strike Global Offensive\\ folder and click Ok");
                fbd.ShowDialog();
                Console.WriteLine(fbd.SelectedPath);

            }

        }

        private void KillsCounterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CsgoIntegration.toCountKills = KillsCounterCheckBox.Checked;
        }

        private void DeathCounterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CsgoIntegration.ToCountDeaths = DeathCounterCheckBox.Checked;
        }
    }
}