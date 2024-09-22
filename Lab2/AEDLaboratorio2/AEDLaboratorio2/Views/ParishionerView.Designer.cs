namespace AEDLaboratorio2.Views
{
    partial class ParishionerView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BtnClearForm = new Button();
            TxtName = new TextBox();
            TxtAddress = new TextBox();
            BtnSave = new Button();
            label6 = new Label();
            TxtMaskPhone = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            CmbPStart = new ComboBox();
            label1 = new Label();
            cmbPEnd = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label10 = new Label();
            label5 = new Label();
            dgPrintParishioner = new DataGridView();
            BtnSearchById = new Button();
            TxtNumSearchID = new NumericUpDown();
            label11 = new Label();
            BtnNext = new Button();
            BtnPrevious = new Button();
            BtnShowAll = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            textCant = new TextBox();
            label7 = new Label();
            dateTimeRegister = new DateTimePicker();
            label12 = new Label();
            btnSaveUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPrintParishioner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumSearchID).BeginInit();
            SuspendLayout();
            // 
            // BtnClearForm
            // 
            BtnClearForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClearForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClearForm.Image = Properties.Resources.clear_icon;
            BtnClearForm.Location = new Point(1013, 373);
            BtnClearForm.Margin = new Padding(3, 4, 3, 4);
            BtnClearForm.Name = "BtnClearForm";
            BtnClearForm.Size = new Size(114, 43);
            BtnClearForm.TabIndex = 65;
            BtnClearForm.Text = "Clean";
            BtnClearForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClearForm.UseVisualStyleBackColor = true;
            BtnClearForm.Click += BtnClearForm_Click;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtName.Location = new Point(119, 207);
            TxtName.Margin = new Padding(3, 4, 3, 4);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(438, 32);
            TxtName.TabIndex = 59;
            TxtName.KeyPress += TxtName_KeyPress;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAddress.Location = new Point(119, 267);
            TxtAddress.Margin = new Padding(3, 4, 3, 4);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(438, 113);
            TxtAddress.TabIndex = 61;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSave.Image = Properties.Resources.new_icon;
            BtnSave.Location = new Point(875, 373);
            BtnSave.Margin = new Padding(3, 4, 3, 4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(114, 43);
            BtnSave.TabIndex = 64;
            BtnSave.Text = "Save";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(23, 207);
            label6.Name = "label6";
            label6.Size = new Size(82, 36);
            label6.TabIndex = 58;
            label6.Text = "Name:";
            // 
            // TxtMaskPhone
            // 
            TxtMaskPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMaskPhone.Location = new Point(119, 412);
            TxtMaskPhone.Margin = new Padding(3, 4, 3, 4);
            TxtMaskPhone.Mask = "0000-0000";
            TxtMaskPhone.Name = "TxtMaskPhone";
            TxtMaskPhone.PromptChar = '#';
            TxtMaskPhone.Size = new Size(438, 32);
            TxtMaskPhone.TabIndex = 63;
            TxtMaskPhone.ValidatingType = typeof(int);
            // 
            // label8
            // 
            label8.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(23, 267);
            label8.Name = "label8";
            label8.Size = new Size(97, 27);
            label8.TabIndex = 60;
            label8.Text = "Adress:";
            // 
            // label9
            // 
            label9.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(25, 412);
            label9.Name = "label9";
            label9.Size = new Size(99, 36);
            label9.TabIndex = 62;
            label9.Text = "Number:";
            // 
            // CmbPStart
            // 
            CmbPStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CmbPStart.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbPStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbPStart.FormattingEnabled = true;
            CmbPStart.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" });
            CmbPStart.Location = new Point(758, 264);
            CmbPStart.Margin = new Padding(3, 4, 3, 4);
            CmbPStart.Name = "CmbPStart";
            CmbPStart.Size = new Size(179, 33);
            CmbPStart.TabIndex = 66;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(664, 264);
            label1.Name = "label1";
            label1.Size = new Size(94, 36);
            label1.TabIndex = 68;
            label1.Text = "Months:";
            // 
            // cmbPEnd
            // 
            cmbPEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPEnd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPEnd.FormattingEnabled = true;
            cmbPEnd.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" });
            cmbPEnd.Location = new Point(948, 264);
            cmbPEnd.Margin = new Padding(3, 4, 3, 4);
            cmbPEnd.Name = "cmbPEnd";
            cmbPEnd.Size = new Size(179, 33);
            cmbPEnd.TabIndex = 69;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(664, 204);
            label2.Name = "label2";
            label2.Size = new Size(94, 36);
            label2.TabIndex = 71;
            label2.Text = "Amount:";
            // 
            // label3
            // 
            label3.Font = new Font("Arial Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(409, 55);
            label3.TabIndex = 72;
            label3.Text = "Parishioner Information";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Arial Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(654, 126);
            label4.Name = "label4";
            label4.Size = new Size(302, 55);
            label4.TabIndex = 73;
            label4.Text = " Tithe Information";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(-3, 476);
            label10.Name = "label10";
            label10.Size = new Size(1160, 10);
            label10.TabIndex = 74;
            // 
            // label5
            // 
            label5.Font = new Font("Arial Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 57);
            label5.Name = "label5";
            label5.Size = new Size(482, 55);
            label5.TabIndex = 75;
            label5.Text = "San Cristobal's Parishioners";
            // 
            // dgPrintParishioner
            // 
            dgPrintParishioner.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgPrintParishioner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPrintParishioner.BackgroundColor = SystemColors.ControlLightLight;
            dgPrintParishioner.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPrintParishioner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPrintParishioner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPrintParishioner.DefaultCellStyle = dataGridViewCellStyle2;
            dgPrintParishioner.Enabled = false;
            dgPrintParishioner.Location = new Point(25, 547);
            dgPrintParishioner.Name = "dgPrintParishioner";
            dgPrintParishioner.ReadOnly = true;
            dgPrintParishioner.RowHeadersWidth = 51;
            dgPrintParishioner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPrintParishioner.Size = new Size(1102, 188);
            dgPrintParishioner.TabIndex = 76;
            // 
            // BtnSearchById
            // 
            BtnSearchById.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearchById.Image = Properties.Resources.search_icon;
            BtnSearchById.Location = new Point(360, 500);
            BtnSearchById.Margin = new Padding(3, 4, 3, 4);
            BtnSearchById.Name = "BtnSearchById";
            BtnSearchById.Size = new Size(126, 43);
            BtnSearchById.TabIndex = 79;
            BtnSearchById.Text = "Search";
            BtnSearchById.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearchById.UseVisualStyleBackColor = true;
            BtnSearchById.Click += BtnSearchById_Click;
            // 
            // TxtNumSearchID
            // 
            TxtNumSearchID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumSearchID.Location = new Point(146, 507);
            TxtNumSearchID.Margin = new Padding(3, 4, 3, 4);
            TxtNumSearchID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumSearchID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumSearchID.Name = "TxtNumSearchID";
            TxtNumSearchID.Size = new Size(208, 32);
            TxtNumSearchID.TabIndex = 78;
            TxtNumSearchID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 503);
            label11.Name = "label11";
            label11.Size = new Size(168, 37);
            label11.TabIndex = 77;
            label11.Text = "Search By ID:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.Bottom;
            BtnNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNext.Image = Properties.Resources.right_icon;
            BtnNext.Location = new Point(836, 768);
            BtnNext.Margin = new Padding(3, 4, 3, 4);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(176, 43);
            BtnNext.TabIndex = 84;
            BtnNext.Text = "Next";
            BtnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.Anchor = AnchorStyles.Bottom;
            BtnPrevious.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPrevious.Image = Properties.Resources.left_icon;
            BtnPrevious.Location = new Point(654, 768);
            BtnPrevious.Margin = new Padding(3, 4, 3, 4);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(176, 43);
            BtnPrevious.TabIndex = 83;
            BtnPrevious.Text = "Back";
            BtnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BtnShowAll
            // 
            BtnShowAll.Anchor = AnchorStyles.Bottom;
            BtnShowAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnShowAll.Image = Properties.Resources.show_all_appointment_icon;
            BtnShowAll.Location = new Point(472, 768);
            BtnShowAll.Margin = new Padding(3, 4, 3, 4);
            BtnShowAll.Name = "BtnShowAll";
            BtnShowAll.Size = new Size(176, 43);
            BtnShowAll.TabIndex = 82;
            BtnShowAll.Text = "Show Details";
            BtnShowAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnShowAll.UseVisualStyleBackColor = true;
            BtnShowAll.Click += BtnShowAll_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Anchor = AnchorStyles.Bottom;
            BtnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Image = Properties.Resources.edit_appointment_icon1;
            BtnUpdate.Location = new Point(108, 768);
            BtnUpdate.Margin = new Padding(3, 4, 3, 4);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(176, 43);
            BtnUpdate.TabIndex = 81;
            BtnUpdate.Text = "Edit";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Bottom;
            BtnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Image = Properties.Resources.delete_appointment_icon;
            BtnDelete.Location = new Point(290, 768);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(176, 43);
            BtnDelete.TabIndex = 80;
            BtnDelete.Text = "Delete";
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // textCant
            // 
            textCant.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCant.Location = new Point(810, 201);
            textCant.Margin = new Padding(3, 4, 3, 4);
            textCant.Name = "textCant";
            textCant.Size = new Size(317, 32);
            textCant.TabIndex = 85;
            textCant.KeyPress += textCant_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(764, 204);
            label7.Name = "label7";
            label7.Size = new Size(41, 36);
            label7.TabIndex = 86;
            label7.Text = "C$";
            // 
            // dateTimeRegister
            // 
            dateTimeRegister.Location = new Point(758, 325);
            dateTimeRegister.Name = "dateTimeRegister";
            dateTimeRegister.Size = new Size(369, 27);
            dateTimeRegister.TabIndex = 87;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Arial Black", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(664, 325);
            label12.Name = "label12";
            label12.Size = new Size(94, 36);
            label12.TabIndex = 88;
            label12.Text = "Date:";
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveUpdate.Image = Properties.Resources.save_icon;
            btnSaveUpdate.Location = new Point(875, 373);
            btnSaveUpdate.Margin = new Padding(3, 4, 3, 4);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(114, 43);
            btnSaveUpdate.TabIndex = 89;
            btnSaveUpdate.Text = "Update";
            btnSaveUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveUpdate.UseVisualStyleBackColor = true;
            btnSaveUpdate.Visible = false;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // ParishionerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 849);
            Controls.Add(btnSaveUpdate);
            Controls.Add(label12);
            Controls.Add(dateTimeRegister);
            Controls.Add(label7);
            Controls.Add(textCant);
            Controls.Add(BtnNext);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnShowAll);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnSearchById);
            Controls.Add(TxtNumSearchID);
            Controls.Add(label11);
            Controls.Add(dgPrintParishioner);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbPEnd);
            Controls.Add(label1);
            Controls.Add(CmbPStart);
            Controls.Add(BtnClearForm);
            Controls.Add(TxtName);
            Controls.Add(TxtAddress);
            Controls.Add(BtnSave);
            Controls.Add(label6);
            Controls.Add(TxtMaskPhone);
            Controls.Add(label8);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "ParishionerView";
            Text = "ParishionerView";
            Load += ParishionerView_Load;
            ((System.ComponentModel.ISupportInitialize)dgPrintParishioner).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumSearchID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClearForm;
        private TextBox TxtName;
        private TextBox TxtAddress;
        private Button BtnSave;
        private Label label6;
        private MaskedTextBox TxtMaskPhone;
        private Label label8;
        private Label label9;
        private ComboBox CmbBoxEndMonth;
        private ComboBox CmbPStart;
        private Label label1;
        private ComboBox cmbPEnd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label10;
        private Label label5;
        private DataGridView dgPrintParishioner;
        private Button BtnSearchById;
        private NumericUpDown TxtNumSearchID;
        private Label label11;
        private Button BtnNext;
        private Button BtnPrevious;
        private Button BtnShowAll;
        private Button BtnUpdate;
        private Button BtnDelete;
        private TextBox textCant;
        private Label label7;
        private DateTimePicker dateTimeRegister;
        private Label label12;
        private Button btnSaveUpdate;
    }
}