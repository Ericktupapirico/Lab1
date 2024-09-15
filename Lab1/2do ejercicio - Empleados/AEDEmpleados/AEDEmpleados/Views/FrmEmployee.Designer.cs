namespace AEDEmpleados.Views
{
    partial class FrmEmployee
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
            LblFormTitle = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TxtNumericSalary = new NumericUpDown();
            TxtNumericChildrens = new NumericUpDown();
            BtnSave = new Button();
            BtnCancel = new Button();
            label9 = new Label();
            RadioBtnMale = new RadioButton();
            RadioBtnFemale = new RadioButton();
            GroupRadioBtn = new GroupBox();
            PicturePhoto = new PictureBox();
            ErrorProvider = new ErrorProvider(components);
            TxtNames = new TextBox();
            TxtSurnames = new TextBox();
            MaskedTxtNationalID = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)TxtNumericSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumericChildrens).BeginInit();
            GroupRadioBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // LblFormTitle
            // 
            LblFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblFormTitle.AutoSize = true;
            LblFormTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFormTitle.Location = new Point(12, 9);
            LblFormTitle.Name = "LblFormTitle";
            LblFormTitle.Size = new Size(159, 25);
            LblFormTitle.TabIndex = 0;
            LblFormTitle.Text = "Nuevo Empleado";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(258, 57);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 4;
            label3.Text = "Número de cédula:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(258, 101);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 5;
            label4.Text = "Nombres:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(258, 144);
            label5.Name = "label5";
            label5.Size = new Size(134, 22);
            label5.TabIndex = 6;
            label5.Text = "Apellidos:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(258, 187);
            label6.Name = "label6";
            label6.Size = new Size(134, 22);
            label6.TabIndex = 10;
            label6.Text = "Salario:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(258, 233);
            label7.Name = "label7";
            label7.Size = new Size(134, 22);
            label7.TabIndex = 11;
            label7.Text = "Cantidad de hijos:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(258, 275);
            label8.Name = "label8";
            label8.Size = new Size(134, 22);
            label8.TabIndex = 12;
            label8.Text = "Sexo:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNumericSalary
            // 
            TxtNumericSalary.DecimalPlaces = 2;
            TxtNumericSalary.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumericSalary.Location = new Point(398, 187);
            TxtNumericSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            TxtNumericSalary.Name = "TxtNumericSalary";
            TxtNumericSalary.Size = new Size(345, 27);
            TxtNumericSalary.TabIndex = 16;
            // 
            // TxtNumericChildrens
            // 
            TxtNumericChildrens.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumericChildrens.Location = new Point(398, 232);
            TxtNumericChildrens.Name = "TxtNumericChildrens";
            TxtNumericChildrens.Size = new Size(345, 27);
            TxtNumericChildrens.TabIndex = 17;
            // 
            // BtnSave
            // 
            BtnSave.Cursor = Cursors.Hand;
            BtnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.Image = Properties.Resources.save_icon;
            BtnSave.Location = new Point(643, 368);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 32);
            BtnSave.TabIndex = 21;
            BtnSave.Text = "Guardar";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Cursor = Cursors.Hand;
            BtnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(526, 368);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(100, 32);
            BtnCancel.TabIndex = 20;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(111, 300);
            label9.Name = "label9";
            label9.Size = new Size(36, 17);
            label9.TabIndex = 19;
            label9.Text = "Foto";
            // 
            // RadioBtnMale
            // 
            RadioBtnMale.AutoSize = true;
            RadioBtnMale.Font = new Font("Segoe UI", 9.75F);
            RadioBtnMale.Location = new Point(0, 12);
            RadioBtnMale.Name = "RadioBtnMale";
            RadioBtnMale.Size = new Size(85, 21);
            RadioBtnMale.TabIndex = 18;
            RadioBtnMale.TabStop = true;
            RadioBtnMale.Text = "Masculino";
            RadioBtnMale.TextImageRelation = TextImageRelation.ImageBeforeText;
            RadioBtnMale.UseVisualStyleBackColor = true;
            // 
            // RadioBtnFemale
            // 
            RadioBtnFemale.AutoSize = true;
            RadioBtnFemale.Font = new Font("Segoe UI", 9.75F);
            RadioBtnFemale.Location = new Point(100, 12);
            RadioBtnFemale.Name = "RadioBtnFemale";
            RadioBtnFemale.Size = new Size(82, 21);
            RadioBtnFemale.TabIndex = 19;
            RadioBtnFemale.TabStop = true;
            RadioBtnFemale.Text = "Femenino";
            RadioBtnFemale.TextImageRelation = TextImageRelation.ImageBeforeText;
            RadioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // GroupRadioBtn
            // 
            GroupRadioBtn.Controls.Add(RadioBtnFemale);
            GroupRadioBtn.Controls.Add(RadioBtnMale);
            GroupRadioBtn.Location = new Point(398, 266);
            GroupRadioBtn.Name = "GroupRadioBtn";
            GroupRadioBtn.Size = new Size(345, 36);
            GroupRadioBtn.TabIndex = 18;
            GroupRadioBtn.TabStop = false;
            // 
            // PicturePhoto
            // 
            PicturePhoto.BackColor = SystemColors.Control;
            PicturePhoto.BorderStyle = BorderStyle.FixedSingle;
            PicturePhoto.Cursor = Cursors.Hand;
            PicturePhoto.Image = Properties.Resources.profile_icon;
            PicturePhoto.InitialImage = null;
            PicturePhoto.Location = new Point(12, 57);
            PicturePhoto.Name = "PicturePhoto";
            PicturePhoto.Size = new Size(230, 240);
            PicturePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicturePhoto.TabIndex = 23;
            PicturePhoto.TabStop = false;
            PicturePhoto.Click += PicturePhoto_Click;
            PicturePhoto.MouseLeave += PicturePhoto_MouseLeave;
            PicturePhoto.MouseHover += PicturePhoto_MouseHover;
            // 
            // ErrorProvider
            // 
            ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider.ContainerControl = this;
            // 
            // TxtNames
            // 
            TxtNames.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNames.Location = new Point(398, 101);
            TxtNames.Name = "TxtNames";
            TxtNames.Size = new Size(345, 27);
            TxtNames.TabIndex = 14;
            TxtNames.KeyPress += TxtNames_KeyPress;
            // 
            // TxtSurnames
            // 
            TxtSurnames.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSurnames.Location = new Point(398, 144);
            TxtSurnames.Name = "TxtSurnames";
            TxtSurnames.Size = new Size(345, 27);
            TxtSurnames.TabIndex = 15;
            TxtSurnames.KeyPress += TxtSurnames_KeyPress;
            // 
            // MaskedTxtNationalID
            // 
            MaskedTxtNationalID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaskedTxtNationalID.Location = new Point(398, 57);
            MaskedTxtNationalID.Mask = "000-000000-0000>L";
            MaskedTxtNationalID.Name = "MaskedTxtNationalID";
            MaskedTxtNationalID.PromptChar = '#';
            MaskedTxtNationalID.Size = new Size(345, 27);
            MaskedTxtNationalID.TabIndex = 13;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 412);
            Controls.Add(MaskedTxtNationalID);
            Controls.Add(TxtSurnames);
            Controls.Add(TxtNames);
            Controls.Add(PicturePhoto);
            Controls.Add(GroupRadioBtn);
            Controls.Add(label9);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(TxtNumericChildrens);
            Controls.Add(TxtNumericSalary);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblFormTitle);
            MaximizeBox = false;
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de empleado";
            ((System.ComponentModel.ISupportInitialize)TxtNumericSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumericChildrens).EndInit();
            GroupRadioBtn.ResumeLayout(false);
            GroupRadioBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicturePhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFormTitle;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown TxtNumericSalary;
        private NumericUpDown TxtNumericChildrens;
        private Button BtnSave;
        private Button BtnCancel;
        private Label label9;
        private RadioButton RadioBtnMale;
        private RadioButton RadioBtnFemale;
        private GroupBox GroupRadioBtn;
        private PictureBox PicturePhoto;
        private ErrorProvider ErrorProvider;
        private TextBox TxtSurnames;
        private TextBox TxtNames;
        private MaskedTextBox MaskedTxtNationalID;
    }
}