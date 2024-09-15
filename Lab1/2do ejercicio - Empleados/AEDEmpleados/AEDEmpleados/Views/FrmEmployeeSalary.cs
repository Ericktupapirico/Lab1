using AEDEmpleados.Entities;
using AEDEmpleados.Models;

namespace AEDEmpleados.Views
{
    public partial class FrmEmployeeSalary : Form
    {
        public FrmEmployeeSalary()
        {
            InitializeComponent();
        }

        private void FrmEmployeeSalary_Load(object sender, EventArgs e) =>
            LblAvgSalary.Text = $"Salario promedio: {EmployeeModel.Instance.AverageSalary()}";

        private void BtnCancel_Click(object sender, EventArgs e) => Close();

        private void BtnApply_Click(object sender, EventArgs e)
        {
            var averageSalary = EmployeeModel.Instance.AverageSalary();
            Predicate<Employee> condition;
            if (RadioBtnGreaterThanAvg.Checked)
                condition = emp => emp.Salary > averageSalary;
            else
                condition = emp => emp.Salary < averageSalary;

            var empCounter = EmployeeModel.Instance.SalaryIncrease(TxtPercentage.Value, condition);
            MessageBox.Show($"Se aumento el salario a {empCounter} empleados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            (Owner as FrmMain)?.RefreshDataGridView();
            Close();
        }
    }
}