using Labdefense.Models;
using Labdefense.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labdefense.Views
{
    public partial class ReportView : Form
    {
        private ExportToExcel? ExportToExcel;
        public ReportView()
        {
            InitializeComponent();
        }
        private void PrintStudents()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ArrayLogicPayments.ArraylogPay.GetPayments();
            ExportToExcel = new ExportToExcel();

        }


        private void ReportView_Load(object sender, EventArgs e)
        {
            PrintStudents();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new()
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                FileName = "PaymentsReport.xlsx"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel?.ExportCloseXml(dataGridView1, dlg.FileName);
                MessageBox.Show("Datos exportados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
