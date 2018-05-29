using System;
using System.IO;
using System.Windows.Forms;

namespace GLSI
{
    public partial class Main : Form
    {

        private string CsgoCfgPath = ":\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\cfg\\gamestate_integration_GLSI.cfg";
        private string LocalCfgPath = "D:\\VisualStudioProjects\\GLSI\\gamestate_integration_GLSI.cfg";
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public string testString;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            testString = System.Reflection.Assembly.GetExecutingAssembly().Location;
            this.TopMost = true;

        }

        private void Main_Closed(object sender, System.EventArgs e)
        {
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ///var HttpServer = new HttpServer();
            //HttpServer.Start();

            //Console.WriteLine(testString.Remove(testString.IndexOf("\\GLSI.exe"), "\\GLSI.exe".Length));
            CsgoIntegration gs = new CsgoIntegration();
            /*
            if (!CsgoIntegration.gsl.Running)
            {
                CsgoIntegration.gsl.Start();
                StartCsgoBtn.Text = "Start CS:GO";
            }
            else
            {
                CsgoIntegration.gsl.Stop();
                StartCsgoBtn.Text = "Stop CS:GO";
            }

            */
        }



        private void setUpCsgoBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\"))
            {
                File.WriteAllText("D" + CsgoCfgPath, File.ReadAllText(LocalCfgPath));
            }

            else if (File.Exists("C:\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\"))
            {
                File.WriteAllText("C" + CsgoCfgPath, File.ReadAllText(LocalCfgPath));
            }
            else
            {
                MessageBox.Show(
                    "Cant Find CSGO Path. Please go to where your steam library is located: \\Counter-Strike Global Offensive\\ folder and click Ok");
                fbd.ShowDialog();
                File.WriteAllText(fbd.SelectedPath + "\\csgo\\cfg\\gamestate_integration_GLSI.cfg", File.ReadAllText(LocalCfgPath));
            }
            MessageBox.Show("Done!");
        }



        private void KillsCounterCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            CsgoIntegration.ToCountKills = KillsCounterTXTCheckBox.Checked;
        }

        private void DeathsCounterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CsgoIntegration.ToCountDeaths = DeathsCounterTXTCheckBox.Checked;
        }

        private void AssistsCounterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CsgoIntegration.ToCountAssists = AssistsCounterTXTCheckBox.Checked;
        }
    }
}
