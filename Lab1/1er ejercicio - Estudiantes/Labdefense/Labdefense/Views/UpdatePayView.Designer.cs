namespace Labdefense.Views
{
    partial class UpdatePayView
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
            comboMotive = new ComboBox();
            textCordobas = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textCarnet = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // comboMotive
            // 
            comboMotive.AutoCompleteCustomSource.AddRange(new string[] { "Matricula", "Aranceles", "Biblioteca", "Constancia de dotas" });
            comboMotive.AutoCompleteMode = AutoCompleteMode.Append;
            comboMotive.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboMotive.BackColor = SystemColors.Info;
            comboMotive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMotive.FormattingEnabled = true;
            comboMotive.Items.AddRange(new object[] { "Matricula", "Aranceles", "Biblioteca", "Constancia de notas", "Otros..." });
            comboMotive.Location = new Point(101, 91);
            comboMotive.Name = "comboMotive";
            comboMotive.Size = new Size(151, 28);
            comboMotive.TabIndex = 38;
            // 
            // textCordobas
            // 
            textCordobas.BackColor = SystemColors.Info;
            textCordobas.Location = new Point(101, 146);
            textCordobas.Name = "textCordobas";
            textCordobas.Size = new Size(125, 27);
            textCordobas.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(69, 153);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 36;
            label3.Text = "C$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(35, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 35;
            label2.Text = "Motivo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(41, 216);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 34;
            label1.Text = "Carnet";
            // 
            // textCarnet
            // 
            textCarnet.BackColor = SystemColors.Info;
            textCarnet.Enabled = false;
            textCarnet.Location = new Point(101, 213);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(125, 27);
            textCarnet.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(275, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.updatebutton;
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.Location = new Point(256, 209);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(41, 34);
            btnUpdate.TabIndex = 40;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // UpdatePayView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 89);
            ClientSize = new Size(580, 304);
            Controls.Add(btnUpdate);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboMotive);
            Controls.Add(textCordobas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textCarnet);
            Name = "UpdatePayView";
            Text = "UpdatePayView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMotive;
        private TextBox textCordobas;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textCarnet;
        private DateTimePicker dateTimePicker1;
        private Button btnUpdate;
    }
}