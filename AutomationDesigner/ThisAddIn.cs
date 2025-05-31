﻿namespace AutomationDesigner
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // get the intial units from the settings from 
            SolidworksWrapper.General.UnitManager.UnitTypes = (SolidworksWrapper.General.UnitTypes)Settings.Default.SelectedUnits;
            InventorWrapper.General.UnitManager.LengthUnits = (InventorWrapper.General.LengthUnits)Settings.Default.SelectedUnits;
            InventorWrapper.General.UnitManager.AngularUnits = (InventorWrapper.General.AngularUnits)Settings.Default.AngularUnits;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
