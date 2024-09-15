namespace AEDLaboratorio2.Views
{
    partial class FrmDentalClinic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            BtnSetSize = new Button();
            TxtNumSize = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            TxtNumAppointmentID = new NumericUpDown();
            TxtServiceName = new TextBox();
            label6 = new Label();
            label3 = new Label();
            DPickerScheduledDate = new DateTimePicker();
            label4 = new Label();
            TxtNumPatientID = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            TxtPatientName = new TextBox();
            TxtPatientSurname = new TextBox();
            BtnClearForm = new Button();
            BtnSave = new Button();
            label10 = new Label();
            BtnSearchById = new Button();
            TxtNumSearchID = new NumericUpDown();
            label9 = new Label();
            BtnSearchPatientByID = new Button();
            numericUpDown1 = new NumericUpDown();
            label11 = new Label();
            BtnNext = new Button();
            BtnPrevious = new Button();
            BtnShowAll = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            DgViewAppointments = new DataGridView();
            DgColumnAppointmentID = new DataGridViewTextBoxColumn();
            DgColumnServiceName = new DataGridViewTextBoxColumn();
            DgColumnScheduledDate = new DataGridViewTextBoxColumn();
            DgColumnPatientID = new DataGridViewTextBoxColumn();
            DgColumnPatientName = new DataGridViewTextBoxColumn();
            DgColumnPatientSurname = new DataGridViewTextBoxColumn();
            ErrorProvider = new ErrorProvider(components);
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)TxtNumSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumAppointmentID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumPatientID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumSearchID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgViewAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 1;
            label1.Text = "Registro de citas médicas";
            // 
            // BtnSetSize
            // 
            BtnSetSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSetSize.Image = Properties.Resources.set_size_icon;
            BtnSetSize.Location = new Point(391, 42);
            BtnSetSize.Name = "BtnSetSize";
            BtnSetSize.Size = new Size(110, 32);
            BtnSetSize.TabIndex = 21;
            BtnSetSize.Text = "Establecer";
            BtnSetSize.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSetSize.UseVisualStyleBackColor = true;
            BtnSetSize.Click += BtnSetSize_Click;
            // 
            // TxtNumSize
            // 
            TxtNumSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumSize.Location = new Point(188, 46);
            TxtNumSize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumSize.Name = "TxtNumSize";
            TxtNumSize.Size = new Size(188, 27);
            TxtNumSize.TabIndex = 20;
            TxtNumSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 19;
            label2.Text = "Cantidad de citas:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(15, 99);
            label5.Name = "label5";
            label5.Size = new Size(156, 27);
            label5.TabIndex = 47;
            label5.Text = "ID cita:";
            // 
            // TxtNumAppointmentID
            // 
            TxtNumAppointmentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumAppointmentID.Location = new Point(188, 99);
            TxtNumAppointmentID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumAppointmentID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumAppointmentID.Name = "TxtNumAppointmentID";
            TxtNumAppointmentID.Size = new Size(307, 27);
            TxtNumAppointmentID.TabIndex = 48;
            TxtNumAppointmentID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TxtServiceName
            // 
            TxtServiceName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtServiceName.Location = new Point(188, 143);
            TxtServiceName.Name = "TxtServiceName";
            TxtServiceName.Size = new Size(307, 27);
            TxtServiceName.TabIndex = 50;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(15, 143);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 49;
            label6.Text = "Nombre del servicio:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(15, 189);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 51;
            label3.Text = "Fecha programada:";
            // 
            // DPickerScheduledDate
            // 
            DPickerScheduledDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DPickerScheduledDate.Location = new Point(188, 189);
            DPickerScheduledDate.Name = "DPickerScheduledDate";
            DPickerScheduledDate.Size = new Size(307, 27);
            DPickerScheduledDate.TabIndex = 52;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(537, 99);
            label4.Name = "label4";
            label4.Size = new Size(84, 27);
            label4.TabIndex = 53;
            label4.Text = "ID paciente:";
            // 
            // TxtNumPatientID
            // 
            TxtNumPatientID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumPatientID.Location = new Point(638, 97);
            TxtNumPatientID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumPatientID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumPatientID.Name = "TxtNumPatientID";
            TxtNumPatientID.Size = new Size(309, 27);
            TxtNumPatientID.TabIndex = 54;
            TxtNumPatientID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(537, 146);
            label7.Name = "label7";
            label7.Size = new Size(84, 27);
            label7.TabIndex = 55;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.Location = new Point(537, 189);
            label8.Name = "label8";
            label8.Size = new Size(84, 27);
            label8.TabIndex = 56;
            label8.Text = "Apellido:";
            // 
            // TxtPatientName
            // 
            TxtPatientName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPatientName.Location = new Point(638, 146);
            TxtPatientName.Name = "TxtPatientName";
            TxtPatientName.Size = new Size(309, 27);
            TxtPatientName.TabIndex = 57;
            // 
            // TxtPatientSurname
            // 
            TxtPatientSurname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPatientSurname.Location = new Point(638, 189);
            TxtPatientSurname.Name = "TxtPatientSurname";
            TxtPatientSurname.Size = new Size(309, 27);
            TxtPatientSurname.TabIndex = 58;
            // 
            // BtnClearForm
            // 
            BtnClearForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClearForm.Image = Properties.Resources.clear_icon;
            BtnClearForm.Location = new Point(136, 236);
            BtnClearForm.Name = "BtnClearForm";
            BtnClearForm.Size = new Size(100, 32);
            BtnClearForm.TabIndex = 60;
            BtnClearForm.Text = "Limpiar";
            BtnClearForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClearForm.UseVisualStyleBackColor = true;
            BtnClearForm.Click += BtnClearForm_Click;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSave.Image = Properties.Resources.save_icon;
            BtnSave.Location = new Point(15, 236);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 32);
            BtnSave.TabIndex = 59;
            BtnSave.Text = "Guardar";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(15, 284);
            label10.Name = "label10";
            label10.Size = new Size(956, 2);
            label10.TabIndex = 61;
            // 
            // BtnSearchById
            // 
            BtnSearchById.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearchById.Image = Properties.Resources.search_appointment_icon;
            BtnSearchById.Location = new Point(347, 306);
            BtnSearchById.Name = "BtnSearchById";
            BtnSearchById.Size = new Size(110, 32);
            BtnSearchById.TabIndex = 64;
            BtnSearchById.Text = "Buscar";
            BtnSearchById.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearchById.UseVisualStyleBackColor = true;
            // 
            // TxtNumSearchID
            // 
            TxtNumSearchID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumSearchID.Location = new Point(159, 308);
            TxtNumSearchID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumSearchID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumSearchID.Name = "TxtNumSearchID";
            TxtNumSearchID.Size = new Size(182, 27);
            TxtNumSearchID.TabIndex = 63;
            TxtNumSearchID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 306);
            label9.Name = "label9";
            label9.Size = new Size(138, 28);
            label9.TabIndex = 62;
            label9.Text = "Buscar por ID cita:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSearchPatientByID
            // 
            BtnSearchPatientByID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearchPatientByID.Image = Properties.Resources.search_by_patient_icon;
            BtnSearchPatientByID.Location = new Point(860, 305);
            BtnSearchPatientByID.Name = "BtnSearchPatientByID";
            BtnSearchPatientByID.Size = new Size(110, 32);
            BtnSearchPatientByID.TabIndex = 67;
            BtnSearchPatientByID.Text = "Buscar";
            BtnSearchPatientByID.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearchPatientByID.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(672, 309);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(182, 27);
            numericUpDown1.TabIndex = 66;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(492, 309);
            label11.Name = "label11";
            label11.Size = new Size(174, 28);
            label11.TabIndex = 65;
            label11.Text = "Buscar por ID paciente:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnNext
            // 
            BtnNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNext.Image = Properties.Resources.right_icon;
            BtnNext.Location = new Point(520, 736);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(110, 32);
            BtnNext.TabIndex = 73;
            BtnNext.Text = "Siguiente";
            BtnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPrevious.Image = Properties.Resources.left_icon;
            BtnPrevious.Location = new Point(398, 736);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(110, 32);
            BtnPrevious.TabIndex = 72;
            BtnPrevious.Text = "Anterior";
            BtnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BtnShowAll
            // 
            BtnShowAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnShowAll.Image = Properties.Resources.show_all_appointment_icon;
            BtnShowAll.Location = new Point(255, 736);
            BtnShowAll.Name = "BtnShowAll";
            BtnShowAll.Size = new Size(132, 32);
            BtnShowAll.TabIndex = 71;
            BtnShowAll.Text = "Mostrar todos";
            BtnShowAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnShowAll.UseVisualStyleBackColor = true;
            BtnShowAll.Click += BtnShowAll_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Image = Properties.Resources.edit_appointment_icon1;
            BtnUpdate.Location = new Point(14, 736);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(110, 32);
            BtnUpdate.TabIndex = 70;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Image = Properties.Resources.delete_appointment_icon;
            BtnDelete.Location = new Point(135, 736);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(110, 32);
            BtnDelete.TabIndex = 68;
            BtnDelete.Text = "Eliminar";
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // DgViewAppointments
            // 
            DgViewAppointments.AllowUserToAddRows = false;
            DgViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgViewAppointments.Columns.AddRange(new DataGridViewColumn[] { DgColumnAppointmentID, DgColumnServiceName, DgColumnScheduledDate, DgColumnPatientID, DgColumnPatientName, DgColumnPatientSurname });
            DgViewAppointments.Location = new Point(15, 357);
            DgViewAppointments.MultiSelect = false;
            DgViewAppointments.Name = "DgViewAppointments";
            DgViewAppointments.RowHeadersVisible = false;
            DgViewAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgViewAppointments.Size = new Size(955, 362);
            DgViewAppointments.TabIndex = 69;
            // 
            // DgColumnAppointmentID
            // 
            DgColumnAppointmentID.DataPropertyName = "Id";
            DgColumnAppointmentID.HeaderText = "ID cita";
            DgColumnAppointmentID.Name = "DgColumnAppointmentID";
            DgColumnAppointmentID.ReadOnly = true;
            DgColumnAppointmentID.Width = 70;
            // 
            // DgColumnServiceName
            // 
            DgColumnServiceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnServiceName.DataPropertyName = "Service";
            DgColumnServiceName.HeaderText = "Nombre del servicio";
            DgColumnServiceName.Name = "DgColumnServiceName";
            DgColumnServiceName.ReadOnly = true;
            // 
            // DgColumnScheduledDate
            // 
            DgColumnScheduledDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnScheduledDate.DataPropertyName = "ScheduledDate";
            DgColumnScheduledDate.HeaderText = "Fecha programada";
            DgColumnScheduledDate.Name = "DgColumnScheduledDate";
            DgColumnScheduledDate.ReadOnly = true;
            // 
            // DgColumnPatientID
            // 
            DgColumnPatientID.DataPropertyName = "Patient.Id";
            DgColumnPatientID.HeaderText = "ID paciente";
            DgColumnPatientID.Name = "DgColumnPatientID";
            DgColumnPatientID.ReadOnly = true;
            DgColumnPatientID.Width = 90;
            // 
            // DgColumnPatientName
            // 
            DgColumnPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnPatientName.DataPropertyName = "Patient.Name";
            DgColumnPatientName.HeaderText = "Nombre";
            DgColumnPatientName.Name = "DgColumnPatientName";
            DgColumnPatientName.ReadOnly = true;
            // 
            // DgColumnPatientSurname
            // 
            DgColumnPatientSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnPatientSurname.DataPropertyName = "Patient.Surname";
            DgColumnPatientSurname.HeaderText = "Apellido";
            DgColumnPatientSurname.Name = "DgColumnPatientSurname";
            DgColumnPatientSurname.ReadOnly = true;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // BtnCancel
            // 
            BtnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancel.Image = Properties.Resources.cancel_icon2;
            BtnCancel.Location = new Point(258, 236);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(100, 32);
            BtnCancel.TabIndex = 74;
            BtnCancel.Text = "Cancelar";
            BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Visible = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmDentalClinic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 787);
            Controls.Add(BtnCancel);
            Controls.Add(BtnNext);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnShowAll);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(DgViewAppointments);
            Controls.Add(BtnSearchPatientByID);
            Controls.Add(numericUpDown1);
            Controls.Add(label11);
            Controls.Add(BtnSearchById);
            Controls.Add(TxtNumSearchID);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(BtnClearForm);
            Controls.Add(BtnSave);
            Controls.Add(TxtPatientSurname);
            Controls.Add(TxtPatientName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TxtNumPatientID);
            Controls.Add(label4);
            Controls.Add(DPickerScheduledDate);
            Controls.Add(label3);
            Controls.Add(TxtServiceName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TxtNumAppointmentID);
            Controls.Add(BtnSetSize);
            Controls.Add(TxtNumSize);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmDentalClinic";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clínica Odontológica";
            Load += FrmDentalClinic_Load;
            ((System.ComponentModel.ISupportInitialize)TxtNumSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumAppointmentID).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumPatientID).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumSearchID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgViewAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnSetSize;
        private NumericUpDown TxtNumSize;
        private Label label2;
        private Label label5;
        private NumericUpDown TxtNumAppointmentID;
        private TextBox TxtServiceName;
        private Label label6;
        private Label label3;
        private DateTimePicker DPickerScheduledDate;
        private Label label4;
        private NumericUpDown TxtNumPatientID;
        private Label label7;
        private Label label8;
        private TextBox TxtPatientName;
        private TextBox TxtPatientSurname;
        private Button BtnClearForm;
        private Button BtnSave;
        private Label label10;
        private Button BtnSearchById;
        private NumericUpDown TxtNumSearchID;
        private Label label9;
        private Button BtnSearchPatientByID;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Button BtnNext;
        private Button BtnPrevious;
        private Button BtnShowAll;
        private Button BtnUpdate;
        private Button BtnDelete;
        private DataGridView DgViewAppointments;
        private ErrorProvider ErrorProvider;
        private DataGridViewTextBoxColumn DgColumnAppointmentID;
        private DataGridViewTextBoxColumn DgColumnServiceName;
        private DataGridViewTextBoxColumn DgColumnScheduledDate;
        private DataGridViewTextBoxColumn DgColumnPatientID;
        private DataGridViewTextBoxColumn DgColumnPatientName;
        private DataGridViewTextBoxColumn DgColumnPatientSurname;
        private Button BtnCancel;
    }
}