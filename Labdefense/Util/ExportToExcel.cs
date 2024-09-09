using ClosedXML.Excel;
using System;
using System.Windows.Forms;

namespace Labdefense.Util
{
    public class ExportToExcel
    {
        public void ExportCloseXml(DataGridView information, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var workSheet = workbook.Worksheets.Add("Sheet1");


                    for (int i = 0; i < information.Columns.Count; i++)
                    {
                        workSheet.Cell(1, i + 1).Value = information.Columns[i].HeaderText;
                    }


                    for (int i = 0; i < information.Rows.Count; i++)
                    {

                        if (!information.Rows[i].IsNewRow)
                        {
                            for (int j = 0; j < information.Columns.Count; j++)
                            {

                                var cellValue = information.Rows[i].Cells[j].Value;
                                workSheet.Cell(i + 2, j + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                            }
                        }
                    }

                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
