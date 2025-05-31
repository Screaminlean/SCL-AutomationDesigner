using Microsoft.Office.Interop.Excel;

namespace AutomationDesigner.ViewModels.Interfaces.Capture
{
    public interface IUpdateExcel
    {
        string SelectedCellName { get; set; }

        void UpdateSelectedCell(Range range);

        void UpdateSelectedSheet(object sender);
    }
}
