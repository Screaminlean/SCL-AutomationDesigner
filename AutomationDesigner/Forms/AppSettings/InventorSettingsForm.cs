using AutomationDesigner.Controls.AppSettings.Inventor;
using System.Windows.Forms;

namespace AutomationDesigner.Forms.AppSettings
{
    public partial class InventorSettingsForm : Form
    {
        public InventorSettingsForm()
        {
            InitializeComponent();

            InventorSettingsControl.CloseForm += CloseForm;
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void InventorSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InventorSettingsControl.CloseForm -= CloseForm;
        }
    }
}
