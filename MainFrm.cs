using Microsoft.Extensions.Configuration;
using WSOperation.ChildFrm;

namespace WSOperation
{
    public partial class MainFrm : Form
    {
        private Form activeForm = null!;

        public MainFrm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void CloseOpenChildForm(Form switchForm)
        {

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "MainFrm")
                    Application.OpenForms[i].Close();
            }

            try
            {
                if (activeForm != null)
                {
                    this.pnlForm.Controls.Remove(switchForm);
                    activeForm.Close();
                }

                activeForm = switchForm;
                switchForm.TopLevel = false;
                switchForm.FormBorderStyle = FormBorderStyle.None;
                switchForm.Dock = DockStyle.Fill;

                this.pnlForm.Controls.Add(switchForm);
                this.pnlForm.Tag = switchForm;

                switchForm.BringToFront();
                switchForm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error message : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // load the configuration file.
            var configBuilder = new ConfigurationBuilder().
               AddJsonFile("appsettings.json").Build();

            // get the section to read
            var configSection = configBuilder.GetSection("AppSettings");

            // get the configuration values in the section.
            var client_id = configSection["id"] ?? null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new RegistrationFrm());
        }

        private void comPortSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new ComPortFrm());
        }

        private void patternSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new PatternFrm());
        }

        private void instuctionManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new InstructionManual());

        }

        private void licensedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new LicensedFrm());

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new AboutFrm());
        }

        private void tEST1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenChildForm(new OperationFrm());
        }
    }
}