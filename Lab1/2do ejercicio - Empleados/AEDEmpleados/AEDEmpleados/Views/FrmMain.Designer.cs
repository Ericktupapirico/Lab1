namespace AEDEmpleados.Views
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DgView = new DataGridView();
            DgColumnPhoto = new DataGridViewImageColumn();
            DgColumnNationalID = new DataGridViewTextBoxColumn();
            DgColumnNames = new DataGridViewTextBoxColumn();
            DgColumnSurnames = new DataGridViewTextBoxColumn();
            DgColumnSalary = new DataGridViewTextBoxColumn();
            DgColumnChildrens = new DataGridViewTextBoxColumn();
            DgColumnSex = new DataGridViewTextBoxColumn();
            label1 = new Label();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnPrevious = new Button();
            BtnNext = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnSalaryIncrease = new Button();
            ((System.ComponentModel.ISupportInitialize)DgView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgView
            // 
            DgView.AllowUserToAddRows = false;
            DgView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgView.ColumnHeadersHeight = 25;
            DgView.Columns.AddRange(new DataGridViewColumn[] { DgColumnPhoto, DgColumnNationalID, DgColumnNames, DgColumnSurnames, DgColumnSalary, DgColumnChildrens, DgColumnSex });
            DgView.Cursor = Cursors.Hand;
            DgView.Location = new Point(12, 48);
            DgView.MultiSelect = false;
            DgView.Name = "DgView";
            DgView.RowHeadersVisible = false;
            DgView.RowTemplate.Height = 50;
            DgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgView.Size = new Size(1240, 574);
            DgView.TabIndex = 0;
            // 
            // DgColumnPhoto
            // 
            DgColumnPhoto.DataPropertyName = "Photo";
            DgColumnPhoto.HeaderText = "Foto";
            DgColumnPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DgColumnPhoto.Name = "DgColumnPhoto";
            DgColumnPhoto.ReadOnly = true;
            DgColumnPhoto.Width = 150;
            // 
            // DgColumnNationalID
            // 
            DgColumnNationalID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnNationalID.DataPropertyName = "NationalID";
            DgColumnNationalID.HeaderText = "Cédula de identidad";
            DgColumnNationalID.Name = "DgColumnNationalID";
            DgColumnNationalID.ReadOnly = true;
            // 
            // DgColumnNames
            // 
            DgColumnNames.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnNames.DataPropertyName = "Name";
            DgColumnNames.HeaderText = "Nombres";
            DgColumnNames.Name = "DgColumnNames";
            DgColumnNames.ReadOnly = true;
            // 
            // DgColumnSurnames
            // 
            DgColumnSurnames.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgColumnSurnames.DataPropertyName = "Surname";
            DgColumnSurnames.HeaderText = "Apellidos";
            DgColumnSurnames.Name = "DgColumnSurnames";
            DgColumnSurnames.ReadOnly = true;
            // 
            // DgColumnSalary
            // 
            DgColumnSalary.DataPropertyName = "Salary";
            DgColumnSalary.HeaderText = "Salario";
            DgColumnSalary.Name = "DgColumnSalary";
            DgColumnSalary.ReadOnly = true;
            DgColumnSalary.Width = 160;
            // 
            // DgColumnChildrens
            // 
            DgColumnChildrens.DataPropertyName = "Childrens";
            DgColumnChildrens.HeaderText = "Hijos";
            DgColumnChildrens.Name = "DgColumnChildrens";
            DgColumnChildrens.ReadOnly = true;
            DgColumnChildrens.Width = 50;
            // 
            // DgColumnSex
            // 
            DgColumnSex.DataPropertyName = "Sex";
            DgColumnSex.HeaderText = "Sexo";
            DgColumnSex.Name = "DgColumnSex";
            DgColumnSex.ReadOnly = true;
            DgColumnSex.Width = 70;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro de Empleados";
            // 
            // BtnNew
            // 
            BtnNew.Cursor = Cursors.Hand;
            BtnNew.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNew.Image = Properties.Resources.new_icon;
            BtnNew.Location = new Point(0, 4);
            BtnNew.Margin = new Padding(0, 2, 15, 0);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(100, 32);
            BtnNew.TabIndex = 1;
            BtnNew.Text = "Nuevo";
            BtnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Cursor = Cursors.Hand;
            BtnEdit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEdit.Image = Properties.Resources.edit_icon;
            BtnEdit.Location = new Point(115, 4);
            BtnEdit.Margin = new Padding(0, 2, 15, 0);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(100, 32);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "Editar";
            BtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.Image = Properties.Resources.delete_icon;
            BtnDelete.Location = new Point(230, 4);
            BtnDelete.Margin = new Padding(0, 2, 15, 0);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(100, 32);
            BtnDelete.TabIndex = 3;
            BtnDelete.Text = "Eliminar";
            BtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.Cursor = Cursors.Hand;
            BtnPrevious.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrevious.Image = Properties.Resources.left_icon;
            BtnPrevious.Location = new Point(520, 4);
            BtnPrevious.Margin = new Padding(0, 2, 15, 0);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(100, 32);
            BtnPrevious.TabIndex = 4;
            BtnPrevious.Text = "Anterior";
            BtnPrevious.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BtnNext
            // 
            BtnNext.Cursor = Cursors.Hand;
            BtnNext.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNext.Image = Properties.Resources.right_icon;
            BtnNext.Location = new Point(635, 4);
            BtnNext.Margin = new Padding(0, 2, 15, 0);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(100, 32);
            BtnNext.TabIndex = 5;
            BtnNext.Text = "Siguiente";
            BtnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(BtnNew);
            flowLayoutPanel1.Controls.Add(BtnEdit);
            flowLayoutPanel1.Controls.Add(BtnDelete);
            flowLayoutPanel1.Controls.Add(BtnSalaryIncrease);
            flowLayoutPanel1.Controls.Add(BtnPrevious);
            flowLayoutPanel1.Controls.Add(BtnNext);
            flowLayoutPanel1.Location = new Point(12, 630);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 2, 5, 2);
            flowLayoutPanel1.Size = new Size(1240, 42);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // BtnSalaryIncrease
            // 
            BtnSalaryIncrease.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalaryIncrease.Image = Properties.Resources.salary_icon;
            BtnSalaryIncrease.Location = new Point(345, 4);
            BtnSalaryIncrease.Margin = new Padding(0, 2, 15, 0);
            BtnSalaryIncrease.Name = "BtnSalaryIncrease";
            BtnSalaryIncrease.Size = new Size(160, 32);
            BtnSalaryIncrease.TabIndex = 6;
            BtnSalaryIncrease.Text = "Aumento de salario";
            BtnSalaryIncrease.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalaryIncrease.UseVisualStyleBackColor = true;
            BtnSalaryIncrease.Click += BtnSalaryIncrease_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(DgView);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AED Registro de Empleados - 2M1-CO";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)DgView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgView;
        private Label label1;
        private Button BtnNew;
        private Button BtnEdit;
        private Button BtnDelete;
        private Button BtnPrevious;
        private Button BtnNext;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewImageColumn DgColumnPhoto;
        private DataGridViewTextBoxColumn DgColumnNationalID;
        private DataGridViewTextBoxColumn DgColumnNames;
        private DataGridViewTextBoxColumn DgColumnSurnames;
        private DataGridViewTextBoxColumn DgColumnSalary;
        private DataGridViewTextBoxColumn DgColumnChildrens;
        private DataGridViewTextBoxColumn DgColumnSex;
        private Button BtnSalaryIncrease;
    }
}
