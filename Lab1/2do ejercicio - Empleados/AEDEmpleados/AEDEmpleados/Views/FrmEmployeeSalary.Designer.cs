namespace AEDEmpleados.Views
{
    partial class FrmEmployeeSalary
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
            TxtPercentage = new NumericUpDown();
            GroupRadioBtn = new GroupBox();
            RadioBtnGreaterThanAvg = new RadioButton();
            RadioBtnLessThanAvg = new RadioButton();
            BtnApply = new Button();
            BtnCancel = new Button();
            LblAvgSalary = new Label();
            ((System.ComponentModel.ISupportInitialize)TxtPercentage).BeginInit();
            GroupRadioBtn.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 0;
            label1.Text = "Aumento de salario";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Porcentaje:";
            // 
            // TxtPercentage
            // 
            TxtPercentage.DecimalPlaces = 2;
            TxtPercentage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPercentage.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            TxtPercentage.Location = new Point(102, 58);
            TxtPercentage.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtPercentage.Name = "TxtPercentage";
            TxtPercentage.Size = new Size(247, 25);
            TxtPercentage.TabIndex = 2;
            TxtPercentage.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // GroupRadioBtn
            // 
            GroupRadioBtn.Controls.Add(RadioBtnGreaterThanAvg);
            GroupRadioBtn.Controls.Add(RadioBtnLessThanAvg);
            GroupRadioBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupRadioBtn.Location = new Point(12, 105);
            GroupRadioBtn.Name = "GroupRadioBtn";
            GroupRadioBtn.Size = new Size(337, 87);
            GroupRadioBtn.TabIndex = 4;
            GroupRadioBtn.TabStop = false;
            GroupRadioBtn.Text = "Seleccionar empleados";
            // 
            // RadioBtnGreaterThanAvg
            // 
            RadioBtnGreaterThanAvg.AutoSize = true;
            RadioBtnGreaterThanAvg.Location = new Point(20, 57);
            RadioBtnGreaterThanAvg.Name = "RadioBtnGreaterThanAvg";
            RadioBtnGreaterThanAvg.Size = new Size(235, 21);
            RadioBtnGreaterThanAvg.TabIndex = 1;
            RadioBtnGreaterThanAvg.Text = "Con salario mayor que el promedio";
            RadioBtnGreaterThanAvg.UseVisualStyleBackColor = true;
            // 
            // RadioBtnLessThanAvg
            // 
            RadioBtnLessThanAvg.AutoSize = true;
            RadioBtnLessThanAvg.Checked = true;
            RadioBtnLessThanAvg.Location = new Point(20, 30);
            RadioBtnLessThanAvg.Name = "RadioBtnLessThanAvg";
            RadioBtnLessThanAvg.Size = new Size(236, 21);
            RadioBtnLessThanAvg.TabIndex = 0;
            RadioBtnLessThanAvg.TabStop = true;
            RadioBtnLessThanAvg.Text = "Con salario menor que el promedio";
            RadioBtnLessThanAvg.UseVisualStyleBackColor = true;
            // 
            // BtnApply
            // 
            BtnApply.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnApply.Location = new Point(249, 254);
            BtnApply.Name = "BtnApply";
            BtnApply.Size = new Size(100, 32);
            BtnApply.TabIndex = 5;
            BtnApply.Text = "Aplicar";
            BtnApply.UseVisualStyleBackColor = true;
            BtnApply.Click += BtnApply_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancel.Location = new Point(133, 254);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(100, 32);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancelar";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // LblAvgSalary
            // 
            LblAvgSalary.AutoSize = true;
            LblAvgSalary.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAvgSalary.Location = new Point(14, 205);
            LblAvgSalary.Name = "LblAvgSalary";
            LblAvgSalary.Size = new Size(114, 17);
            LblAvgSalary.TabIndex = 7;
            LblAvgSalary.Text = "Salario promedio:";
            // 
            // FrmEmployeeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 301);
            Controls.Add(LblAvgSalary);
            Controls.Add(BtnCancel);
            Controls.Add(BtnApply);
            Controls.Add(GroupRadioBtn);
            Controls.Add(TxtPercentage);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmEmployeeSalary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aumento de salario";
            Load += FrmEmployeeSalary_Load;
            ((System.ComponentModel.ISupportInitialize)TxtPercentage).EndInit();
            GroupRadioBtn.ResumeLayout(false);
            GroupRadioBtn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown TxtPercentage;
        private GroupBox GroupRadioBtn;
        private RadioButton RadioBtnLessThanAvg;
        private RadioButton RadioBtnGreaterThanAvg;
        private Button BtnApply;
        private Button BtnCancel;
        private Label LblAvgSalary;
    }
}