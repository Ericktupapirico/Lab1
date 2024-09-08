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
            textCordobas.Location = new Point(101, 146);
            textCordobas.Name = "textCordobas";
            textCordobas.Size = new Size(125, 27);
            textCordobas.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 153);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 36;
            label3.Text = "C$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 95);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 35;
            label2.Text = "Motivo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 220);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 34;
            label1.Text = "Carnet";
            // 
            // textCarnet
            // 
            textCarnet.Location = new Point(101, 213);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(125, 27);
            textCarnet.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(275, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(423, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdatePayView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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