using AEDEmpleados.Entities;
using AEDEmpleados.Models;
using AEDEmpleados.Util;
using AEDEmpleados.Views.Enums;

namespace AEDEmpleados.Views
{
    public partial class FrmEmployee : Form
    {
        private readonly FrameOperation _operation;
        private readonly Employee? _employee;
        private bool _isValidForm;

        public FrmEmployee(FrameOperation operation)
        {
            InitializeComponent();
            _operation = operation;
            InitControls();
        }

        public FrmEmployee(FrameOperation operation, Employee employee)
        {
            InitializeComponent();
            _operation = operation;
            _employee = employee;
            InitControls();
            FillForm();
        }

        private void InitControls()
        {
            AttachEvents();
            ValidateFields();
            SetFormTitle();
        }

        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtSurnames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e) => Close();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                NationalID = MaskedTxtNationalID.Text,
                Name = TxtNames.Text,
                Surname = TxtSurnames.Text,
                Childrens = Convert.ToInt32(TxtNumericChildrens.Value),
                Salary = TxtNumericSalary.Value,
                Sex = RadioBtnMale.Checked ? Sex.Male : Sex.Female,
                Photo = PicturePhoto.Image?.ToByteArray()
            };

            if (_operation == FrameOperation.Create)
            {
                var emp = EmployeeModel.Instance.Find(employee.NationalID);
                if (emp is not null)
                {
                    MessageBox.Show("Ya existe un empleado con la misma cédula de identidad", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EmployeeModel.Instance.Add(employee);
            }
            else
                EmployeeModel.Instance.Update(employee);

            (Owner as FrmMain)?.RefreshDataGridView();

            Close();
        }

        private void PicturePhoto_MouseHover(object sender, EventArgs e) =>
            PicturePhoto.BackColor = SystemColors.GradientActiveCaption;

        private void PicturePhoto_MouseLeave(object sender, EventArgs e) =>
            PicturePhoto.BackColor = SystemColors.Control;

        private void PicturePhoto_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff|All Files|*.*",
                Title = "Select an Image",
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                PicturePhoto.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void AttachEvents()
        {
            MaskedTxtNationalID.TextChanged += (s, e) => ValidateFields();
            TxtNames.TextChanged += (s, e) => ValidateFields();
            TxtSurnames.TextChanged += (s, e) => ValidateFields();
            TxtNumericSalary.ValueChanged += (s, e) => ValidateFields();
            RadioBtnMale.CheckedChanged += (s, e) => ValidateFields();
            RadioBtnFemale.CheckedChanged += (s, e) => ValidateFields();
        }

        private void ValidateFields()
        {
            bool[] validationResults =
            [
                ValidateNationalID(),
                ValidateNames(),
                ValidateSurnames(),
                ValidateSalary(),
                ValidateSex()
            ];

            _isValidForm = true;
            foreach (bool result in validationResults)
            {
                if (!result)
                {
                    _isValidForm = false;
                    break;
                }
            }

            BtnSave.Enabled = _isValidForm;
        }

        private void FillForm()
        {
            if (_employee is null)
            {
                MessageBox.Show("No se encontró información del empleado para actualizar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MaskedTxtNationalID.Text = _employee.NationalID;
            MaskedTxtNationalID.ReadOnly = true;

            TxtNames.Text = _employee.Name;
            TxtSurnames.Text = _employee.Surname;
            TxtNumericSalary.Value = _employee.Salary;
            TxtNumericChildrens.Value = _employee.Childrens;

            RadioBtnMale.Checked = _employee.Sex == Sex.Male;
            RadioBtnFemale.Checked = _employee.Sex == Sex.Female;

            PicturePhoto.Image = _employee.Photo?.ToImage();
        }

        private void SetFormTitle() =>
            LblFormTitle.Text = _operation == FrameOperation.Create ? "Nuevo Empleado" : "Editar Empleado";

        private bool ValidateNationalID()
        {
            if (!MaskedTxtNationalID.MaskCompleted)
            {
                ErrorProvider.SetError(MaskedTxtNationalID, 
                    "El número de cédula no es correcto, formato ###-######-####X");
                return false;
            }
            ErrorProvider.SetError(MaskedTxtNationalID, string.Empty);
            return true;
        }

        private bool ValidateNames()
        {
            if (string.IsNullOrWhiteSpace(TxtNames.Text))
            {
                ErrorProvider.SetError(TxtNames, "Los nombres son obligatorios");
                return false;
            }
            ErrorProvider.SetError(TxtNames, string.Empty);
            return true;
        }

        private bool ValidateSurnames()
        {
            if (string.IsNullOrWhiteSpace(TxtSurnames.Text))
            {
                ErrorProvider.SetError(TxtSurnames, "Los apellidos son obligatorios");
                return false;
            }
            ErrorProvider.SetError(TxtSurnames, string.Empty);
            return true;
        }

        private bool ValidateSalary()
        {
            if (TxtNumericSalary.Value == 0)
            {
                ErrorProvider.SetError(TxtNumericSalary, "El salario debe ser mayor a 0");
                return false;
            }
            ErrorProvider.SetError(TxtNumericSalary, string.Empty);
            return true;
        }

        private bool ValidateSex()
        {
            if (!RadioBtnMale.Checked && !RadioBtnFemale.Checked)
            {
                ErrorProvider.SetError(GroupRadioBtn, "Debe seleccionar un sexo");
                return false;
            }
            ErrorProvider.SetError(GroupRadioBtn, string.Empty);
            return true;
        }
    }
}