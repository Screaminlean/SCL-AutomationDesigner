using AutomationDesigner.Controls.AppSettings.Solidworks;
using System.Windows.Forms;

namespace AutomationDesigner.Forms.AppSettings
{
    public partial class SolidworksSettingsForm : Form
    {
        public SolidworksSettingsForm()
        {
            InitializeComponent();

            SolidworksSettingsControl.CloseForm += CloseForm;
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void SolidworksSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SolidworksSettingsControl.CloseForm -= CloseForm;
        }
    }
}
