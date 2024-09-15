namespace AEDLaboratorio2.Views
{
    partial class FrmChurch
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
            label1 = new Label();
            label2 = new Label();
            TxtNumSize = new NumericUpDown();
            BtnSetSize = new Button();
            BtnSearchByRange = new Button();
            CmbBoxEndMonth = new ComboBox();
            CmbBoxStartMonth = new ComboBox();
            label3 = new Label();
            BtnSearchById = new Button();
            BtnShowAll = new Button();
            BtnUpdate = new Button();
            TxtNumSearchID = new NumericUpDown();
            label4 = new Label();
            DgViewParishioner = new DataGridView();
            DgColumnID = new DataGridViewTextBoxColumn();
            DgColumnName = new DataGridViewTextBoxColumn();
            DgColumnAddress = new DataGridViewTextBoxColumn();
            DgColumnPhone = new DataGridViewTextBoxColumn();
            DgColumnTotalTithe = new DataGridViewTextBoxColumn();
            BtnDelete = new Button();
            TxtName = new TextBox();
            TxtAddress = new TextBox();
            BtnSave = new Button();
            DgViewTithes = new DataGridView();
            DgColumnMonth = new DataGridViewComboBoxColumn();
            DgColumnTithe = new DataGridViewTextBoxColumn();
            label5 = new Label();
            TxtNumID = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            TxtMaskPhone = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            BtnClearForm = new Button();
            BtnPrevious = new Button();
            BtnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)TxtNumSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumSearchID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgViewParishioner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgViewTithes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro de diezmos";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 2;
            label2.Text = "Cantidad de feligreses:";
            // 
            // TxtNumSize
            // 
            TxtNumSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumSize.Location = new Point(192, 51);
            TxtNumSize.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumSize.Name = "TxtNumSize";
            TxtNumSize.Size = new Size(186, 27);
            TxtNumSize.TabIndex = 3;
            TxtNumSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnSetSize
            // 
            BtnSetSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSetSize.Image = Properties.Resources.set_size_icon;
            BtnSetSize.Location = new Point(384, 49);
            BtnSetSize.Name = "BtnSetSize";
            BtnSetSize.Size = new Size(110, 32);
            BtnSetSize.TabIndex = 18;
            BtnSetSize.Text = "Establecer";
            BtnSetSize.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSetSize.UseVisualStyleBackColor = true;
            BtnSetSize.Click += BtnSetSize_Click;
            // 
            // BtnSearchByRange
            // 
            BtnSearchByRange.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearchByRange.Image = Properties.Resources.search_icon;
            BtnSearchByRange.Location = new Point(947, 418);
            BtnSearchByRange.Name = "BtnSearchByRange";
            BtnSearchByRange.Size = new Size(110, 32);
            BtnSearchByRange.TabIndex = 44;
            BtnSearchByRange.Text = "Buscar";
            BtnSearchByRange.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearchByRange.UseVisualStyleBackColor = true;
            // 
            // CmbBoxEndMonth
            // 
            CmbBoxEndMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxEndMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbBoxEndMonth.FormattingEnabled = true;
            CmbBoxEndMonth.Location = new Point(789, 419);
            CmbBoxEndMonth.Name = "CmbBoxEndMonth";
            CmbBoxEndMonth.Size = new Size(152, 28);
            CmbBoxEndMonth.TabIndex = 43;
            // 
            // CmbBoxStartMonth
            // 
            CmbBoxStartMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxStartMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbBoxStartMonth.FormattingEnabled = true;
            CmbBoxStartMonth.Location = new Point(621, 419);
            CmbBoxStartMonth.Name = "CmbBoxStartMonth";
            CmbBoxStartMonth.Size = new Size(152, 28);
            CmbBoxStartMonth.TabIndex = 42;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(433, 419);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 41;
            label3.Text = "Buscar por rango meses:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSearchById
            // 
            BtnSearchById.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSearchById.Image = Properties.Resources.search_icon;
            BtnSearchById.Location = new Point(311, 419);
            BtnSearchById.Name = "BtnSearchById";
            BtnSearchById.Size = new Size(110, 32);
            BtnSearchById.TabIndex = 40;
            BtnSearchById.Text = "Buscar";
            BtnSearchById.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearchById.UseVisualStyleBackColor = true;
            // 
            // BtnShowAll
            // 
            BtnShowAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnShowAll.Image = Properties.Resources.show_all_icon;
            BtnShowAll.Location = new Point(277, 846);
            BtnShowAll.Name = "BtnShowAll";
            BtnShowAll.Size = new Size(132, 32);
            BtnShowAll.TabIndex = 39;
            BtnShowAll.Text = "Mostrar todos";
            BtnShowAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnShowAll.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUpdate.Image = Properties.Resources.edit_icon1;
            BtnUpdate.Location = new Point(12, 846);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(110, 32);
            BtnUpdate.TabIndex = 38;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtNumSearchID
            // 
            TxtNumSearchID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumSearchID.Location = new Point(123, 421);
            TxtNumSearchID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumSearchID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumSearchID.Name = "TxtNumSearchID";
            TxtNumSearchID.Size = new Size(182, 27);
            TxtNumSearchID.TabIndex = 37;
            TxtNumSearchID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 419);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 36;
            label4.Text = "Buscar por ID:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DgViewParishioner
            // 
            DgViewParishioner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgViewParishioner.Columns.AddRange(new DataGridViewColumn[] { DgColumnID, DgColumnName, DgColumnAddress, DgColumnPhone, DgColumnTotalTithe });
            DgViewParishioner.Location = new Point(12, 466);
            DgViewParishioner.MultiSelect = false;
            DgViewParishioner.Name = "DgViewParishioner";
            DgViewParishioner.RowHeadersVisible = false;
            DgViewParishioner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgViewParishioner.Size = new Size(1045, 362);
            DgViewParishioner.TabIndex = 35;
            // 
            // DgColumnID
            // 
            DgColumnID.HeaderText = "ID";
            DgColumnID.Name = "DgColumnID";
            DgColumnID.ReadOnly = true;
            DgColumnID.Width = 40;
            // 
            // DgColumnName
            // 
            DgColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnName.HeaderText = "Nombre";
            DgColumnName.Name = "DgColumnName";
            DgColumnName.ReadOnly = true;
            // 
            // DgColumnAddress
            // 
            DgColumnAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnAddress.HeaderText = "Dirección";
            DgColumnAddress.Name = "DgColumnAddress";
            DgColumnAddress.ReadOnly = true;
            // 
            // DgColumnPhone
            // 
            DgColumnPhone.HeaderText = "Número de teléfono";
            DgColumnPhone.Name = "DgColumnPhone";
            DgColumnPhone.ReadOnly = true;
            DgColumnPhone.Width = 140;
            // 
            // DgColumnTotalTithe
            // 
            DgColumnTotalTithe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnTotalTithe.HeaderText = "Diezmos";
            DgColumnTotalTithe.Name = "DgColumnTotalTithe";
            DgColumnTotalTithe.ReadOnly = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDelete.Image = Properties.Resources.delete_icon1;
            BtnDelete.Location = new Point(143, 846);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(110, 32);
            BtnDelete.TabIndex = 34;
            BtnDelete.Text = "Eliminar";
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtName.Location = new Point(110, 150);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(384, 27);
            TxtName.TabIndex = 48;
            // 
            // TxtAddress
            // 
            TxtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAddress.Location = new Point(110, 195);
            TxtAddress.Multiline = true;
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(384, 86);
            TxtAddress.TabIndex = 50;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSave.Image = Properties.Resources.new_icon;
            BtnSave.Location = new Point(12, 351);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 32);
            BtnSave.TabIndex = 54;
            BtnSave.Text = "Guardar";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // DgViewTithes
            // 
            DgViewTithes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgViewTithes.Columns.AddRange(new DataGridViewColumn[] { DgColumnMonth, DgColumnTithe });
            DgViewTithes.Location = new Point(527, 150);
            DgViewTithes.MultiSelect = false;
            DgViewTithes.Name = "DgViewTithes";
            DgViewTithes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DgViewTithes.Size = new Size(533, 181);
            DgViewTithes.TabIndex = 55;
            // 
            // DgColumnMonth
            // 
            DgColumnMonth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnMonth.HeaderText = "Mes";
            DgColumnMonth.Name = "DgColumnMonth";
            DgColumnMonth.Resizable = DataGridViewTriState.True;
            DgColumnMonth.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DgColumnTithe
            // 
            DgColumnTithe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnTithe.HeaderText = "Diezmo";
            DgColumnTithe.Name = "DgColumnTithe";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(12, 106);
            label5.Name = "label5";
            label5.Size = new Size(78, 27);
            label5.TabIndex = 45;
            label5.Text = "ID:";
            // 
            // TxtNumID
            // 
            TxtNumID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumID.Location = new Point(110, 106);
            TxtNumID.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtNumID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtNumID.Name = "TxtNumID";
            TxtNumID.Size = new Size(384, 27);
            TxtNumID.TabIndex = 46;
            TxtNumID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(527, 106);
            label7.Name = "label7";
            label7.Size = new Size(132, 27);
            label7.TabIndex = 53;
            label7.Text = "Diezmo mensual:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(12, 150);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 47;
            label6.Text = "Nombre:";
            // 
            // TxtMaskPhone
            // 
            TxtMaskPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMaskPhone.Location = new Point(110, 304);
            TxtMaskPhone.Mask = "0000-0000";
            TxtMaskPhone.Name = "TxtMaskPhone";
            TxtMaskPhone.PromptChar = '#';
            TxtMaskPhone.Size = new Size(384, 27);
            TxtMaskPhone.TabIndex = 52;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label8.Location = new Point(12, 195);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 49;
            label8.Text = "Dirección:";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.Location = new Point(12, 304);
            label9.Name = "label9";
            label9.Size = new Size(78, 27);
            label9.TabIndex = 51;
            label9.Text = "Teléfono:";
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(12, 400);
            label10.Name = "label10";
            label10.Size = new Size(1042, 2);
            label10.TabIndex = 56;
            // 
            // BtnClearForm
            // 
            BtnClearForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClearForm.Image = Properties.Resources.clear_icon;
            BtnClearForm.Location = new Point(133, 351);
            BtnClearForm.Name = "BtnClearForm";
            BtnClearForm.Size = new Size(100, 32);
            BtnClearForm.TabIndex = 57;
            BtnClearForm.Text = "Limpiar";
            BtnClearForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClearForm.UseVisualStyleBackColor = true;
            // 
            // BtnPrevious
            // 
            BtnPrevious.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPrevious.Image = Properties.Resources.left_icon;
            BtnPrevious.Location = new Point(433, 846);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(110, 32);
            BtnPrevious.TabIndex = 58;
            BtnPrevious.Text = "Anterior";
            BtnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            BtnNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNext.Image = Properties.Resources.right_icon;
            BtnNext.Location = new Point(566, 846);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(110, 32);
            BtnNext.TabIndex = 59;
            BtnNext.Text = "Siguiente";
            BtnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNext.UseVisualStyleBackColor = true;
            // 
            // FrmChurch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 892);
            Controls.Add(BtnNext);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnClearForm);
            Controls.Add(label10);
            Controls.Add(TxtName);
            Controls.Add(TxtAddress);
            Controls.Add(BtnSave);
            Controls.Add(DgViewTithes);
            Controls.Add(label5);
            Controls.Add(TxtNumID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TxtMaskPhone);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(BtnSearchByRange);
            Controls.Add(CmbBoxEndMonth);
            Controls.Add(BtnSetSize);
            Controls.Add(CmbBoxStartMonth);
            Controls.Add(TxtNumSize);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnSearchById);
            Controls.Add(BtnShowAll);
            Controls.Add(label1);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtNumSearchID);
            Controls.Add(BtnDelete);
            Controls.Add(label4);
            Controls.Add(DgViewParishioner);
            MaximizeBox = false;
            Name = "FrmChurch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Diezmo Iglesia";
            ((System.ComponentModel.ISupportInitialize)TxtNumSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumSearchID).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgViewParishioner).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgViewTithes).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown TxtNumSize;
        private Button BtnSetSize;
        private Button BtnSearchByRange;
        private ComboBox CmbBoxEndMonth;
        private ComboBox CmbBoxStartMonth;
        private Label label3;
        private Button BtnSearchById;
        private Button BtnShowAll;
        private Button BtnUpdate;
        private NumericUpDown TxtNumSearchID;
        private Label label4;
        private DataGridView DgViewParishioner;
        private DataGridViewTextBoxColumn DgColumnID;
        private DataGridViewTextBoxColumn DgColumnName;
        private DataGridViewTextBoxColumn DgColumnAddress;
        private DataGridViewTextBoxColumn DgColumnPhone;
        private DataGridViewTextBoxColumn DgColumnTotalTithe;
        private Button BtnDelete;
        private TextBox TxtName;
        private TextBox TxtAddress;
        private Button BtnSave;
        private DataGridView DgViewTithes;
        private Label label5;
        private NumericUpDown TxtNumID;
        private Label label7;
        private Label label6;
        private MaskedTextBox TxtMaskPhone;
        private Label label8;
        private Label label9;
        private DataGridViewComboBoxColumn DgColumnMonth;
        private DataGridViewTextBoxColumn DgColumnTithe;
        private Label label10;
        private Button BtnClearForm;
        private Button BtnPrevious;
        private Button BtnNext;
    }
}