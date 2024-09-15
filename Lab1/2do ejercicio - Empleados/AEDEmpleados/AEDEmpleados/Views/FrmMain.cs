using AEDEmpleados.Entities;
using AEDEmpleados.Models;
using AEDEmpleados.Views.Enums;

namespace AEDEmpleados.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateControlState();
        }

        private void UpdateControlState() =>
            BtnEdit.Enabled = BtnDelete.Enabled = BtnPrevious.Enabled =
            BtnNext.Enabled = BtnSalaryIncrease.Enabled = DgView.Rows.Count > 0;

        public void RefreshDataGridView()
        {
            DgView.DataSource = EmployeeModel.Instance.GetAll();
            UpdateControlState();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var frmEmployee = new FrmEmployee(FrameOperation.Create)
            {
                Owner = this
            };
            frmEmployee.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = DgView.SelectedRows[0].Index;
            if (DgView.Rows[selectedRowIndex].DataBoundItem is not Employee selectedEmployee)
            {
                MessageBox.Show("No se ha seleccionado ningún empleado para editar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var frmEmployee = new FrmEmployee(FrameOperation.Update, selectedEmployee)
            {
                Owner = this
            };
            frmEmployee.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = DgView.SelectedRows[0].Index;
            if (DgView.Rows[selectedRowIndex].DataBoundItem is not Employee selectedEmployee)
            {
                MessageBox.Show("No se ha seleccionado ningún empleado para eliminar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(selectedEmployee.NationalID))
            {
                MessageBox.Show("No se ha encontrado cédula del empleado a eliminar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dlgResult = MessageBox.Show($"Seguro que desea eliminar a " +
                $"{selectedEmployee.Name} {selectedEmployee.Surname}?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No)
                return;

            EmployeeModel.Instance.Delete(selectedEmployee.NationalID);
            RefreshDataGridView();
        }

        private void BtnSalaryIncrease_Click(object sender, EventArgs e)
        {
            var frmEmployeeSalary = new FrmEmployeeSalary()
            {
                Owner = this
            };
            frmEmployeeSalary.ShowDialog();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            var currentRowIndex = DgView.SelectedRows[0].Index;
            if (currentRowIndex > 0)
                DgView.Rows[currentRowIndex - 1].Selected = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var currentRowIndex = DgView.SelectedRows[0].Index;
            if (currentRowIndex < DgView.Rows.Count - 1)
                DgView.Rows[currentRowIndex + 1].Selected = true;
        }
    }
}