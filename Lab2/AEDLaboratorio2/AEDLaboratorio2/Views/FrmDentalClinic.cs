using AEDLaboratorio2.Entities.DentalClinic;
using AEDLaboratorio2.Models.DentalClinic;
using AEDLaboratorio2.Views.Enums;

namespace AEDLaboratorio2.Views
{
    public partial class FrmDentalClinic : Form
    {
        private readonly AppointmentModel _appointmentModel = new();
        private FormOperation _formOperation = FormOperation.Create;
        private bool _isValidForm;

        public FrmDentalClinic()
        {
            InitializeComponent();
            TxtServiceName.KeyPress += TxtKeyPress;
            TxtPatientName.KeyPress += TxtKeyPress;
            TxtPatientSurname.KeyPress += TxtKeyPress;
            TxtServiceName.TextChanged += (s, e) => TxtTextChanged();
            TxtPatientName.TextChanged += (s, e) => TxtTextChanged();
            TxtPatientSurname.TextChanged += (s, e) => TxtTextChanged();
            TxtTextChanged();
        }

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
            var (result, msg) = _appointmentModel.InitializeArray(Convert.ToInt32(TxtNumSize.Value));
            if (!result)
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClearForm_Click(object sender, EventArgs e) => ClearForm();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var appointment = new Appointment()
            {
                Id = Convert.ToInt32(TxtNumAppointmentID.Value),
                Service = TxtServiceName.Text,
                ScheduledDate = DPickerScheduledDate.Value,
                Patient = new Patient()
                {
                    Id = Convert.ToInt32(TxtNumPatientID.Value),
                    Name = TxtPatientName.Text,
                    Surname = TxtPatientSurname.Text
                }
            };

            (bool result, string message) tuple;
            if (_formOperation == FormOperation.Create)
                tuple = _appointmentModel.Add(appointment);
            else
                tuple = _appointmentModel.Update(appointment);

            if (!tuple.result)
            {
                MessageBox.Show(tuple.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_formOperation == FormOperation.Update)
            {
                _formOperation = FormOperation.Create;
                BtnCancel.Visible = false;
            }

            RefreshDataGridView();
            ClearForm();
        }

        private void TxtKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtTextChanged()
        {
            (bool isServiceValid, bool isPatientNameValid, bool isPatientSurnameValid) = ValidateTextBoxes();
            _isValidForm = isServiceValid && isPatientNameValid && isPatientSurnameValid;
            BtnSave.Enabled = _isValidForm;
        }

        private bool ValidateTextBox(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                ErrorProvider.SetError(textBox, errorMessage);
                return false;
            }

            ErrorProvider.SetError(textBox, string.Empty);

            return true;
        }

        private (bool isServiceValid, bool isPatientNameValid, bool isPatientSurnameValid) ValidateTextBoxes()
        {
            bool isServiceValid = ValidateTextBox(TxtServiceName, "Nombre del servicio es obligatorio");
            bool isPatientNameValid = ValidateTextBox(TxtPatientName, "Nombre del paciente es obligatorio");
            bool isPatientSurnameValid = ValidateTextBox(TxtPatientSurname, "Apellido del paciente es obligatorio");

            return (isServiceValid, isPatientNameValid, isPatientSurnameValid);
        }

        private void ClearForm()
        {
            TxtNumAppointmentID.Value = TxtNumAppointmentID.Minimum;
            TxtServiceName.Text = string.Empty;
            DPickerScheduledDate.Value = DateTime.Now;
            TxtNumPatientID.Value = TxtNumPatientID.Minimum;
            TxtPatientName.Text = string.Empty;
            TxtPatientSurname.Text = string.Empty;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (DgViewAppointments.SelectedRows.Count <= 0)
                return;

            var currentRowIndex = DgViewAppointments.SelectedRows[0].Index;
            if (currentRowIndex > 0)
                DgViewAppointments.Rows[currentRowIndex - 1].Selected = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (DgViewAppointments.SelectedRows.Count <= 0)
                return;

            var currentRowIndex = DgViewAppointments.SelectedRows[0].Index;
            if (currentRowIndex < DgViewAppointments.Rows.Count - 1)
                DgViewAppointments.Rows[currentRowIndex + 1].Selected = true;
        }

        private void BtnShowAll_Click(object sender, EventArgs e) => RefreshDataGridView();

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = DgViewAppointments.SelectedRows[0].Index;
            if (DgViewAppointments.Rows[selectedRowIndex].DataBoundItem is not Appointment selectedAppointment)
            {
                MessageBox.Show("No se ha seleccionado ninguna cita para eliminar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var dlgResult = MessageBox.Show($"Seguro que desea eliminar la cita para " +
                $"{selectedAppointment.Patient?.Name} {selectedAppointment.Patient?.Surname}?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No)
                return;

            var (result, message) = _appointmentModel.Delete(selectedAppointment.Id);
            if (!result)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DgViewAppointments.DataSource = _appointmentModel.GetAll();
            UpdateControlState(() => DgViewAppointments.Rows.Count > 0);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = DgViewAppointments.SelectedRows[0].Index;
            if (DgViewAppointments.Rows[selectedRowIndex].DataBoundItem is not Appointment selectedAppointment)
            {
                MessageBox.Show("No se ha seleccionado ninguna cita para actualizar", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selectedAppointment.Patient is null)
            {
                MessageBox.Show("No se encontró al paciente asociado a la cita seleccionada", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TxtNumAppointmentID.Value = selectedAppointment.Id;
            TxtNumAppointmentID.ReadOnly = true;
            TxtServiceName.Text = selectedAppointment.Service;
            DPickerScheduledDate.Value = selectedAppointment.ScheduledDate;
            TxtNumPatientID.Value = selectedAppointment.Patient.Id;
            TxtNumPatientID.ReadOnly = true;
            TxtPatientName.Text = selectedAppointment.Patient.Name;
            TxtPatientSurname.Text = selectedAppointment.Patient.Surname;

            _formOperation = FormOperation.Update;
            UpdateControlState(() => false);
            BtnCancel.Visible = true;
        }

        private void UpdateControlState(Func<bool> condition)
        {
            BtnSearchById.Enabled = BtnSearchPatientByID.Enabled = BtnUpdate.Enabled =
            BtnDelete.Enabled = BtnShowAll.Enabled = BtnPrevious.Enabled = BtnNext.Enabled = condition();
        }

        private void FrmDentalClinic_Load(object sender, EventArgs e) =>
            UpdateControlState(() => DgViewAppointments.Rows.Count > 0);

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (_formOperation == FormOperation.Create)
                return;

            var dlgResult = MessageBox.Show("Seguro que desea cancelar la actualización de la cita?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.No)
                return;

            _formOperation = FormOperation.Create;
            BtnCancel.Visible = false;
            RefreshDataGridView();
            ClearForm();
        }
    }
}