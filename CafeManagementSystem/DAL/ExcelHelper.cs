using Microsoft.Office.Interop.Excel;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace CafeManagementSystem.DAL
{
    internal class ExcelHelper
    {
        private COMExcel.Application _excelApp;
        private COMExcel.Workbook _workbook;
        private COMExcel.Worksheet _worksheet;

        public ExcelHelper(string filePath)
        {
            _excelApp = new COMExcel.Application();
            _workbook = _excelApp.Workbooks.Open(filePath);
            _worksheet = (Worksheet)_workbook.Worksheets[1];
        }
    }
}
