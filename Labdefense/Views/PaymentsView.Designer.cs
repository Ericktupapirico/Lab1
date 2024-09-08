namespace Labdefense.Views
{
    partial class PaymentsView
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
            btnRegister = new Button();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textCarnet = new TextBox();
            dgStudents = new DataGridView();
            textCordobas = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboMotive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgStudents).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.Location = new Point(871, 158);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(167, 29);
            btnRegister.TabIndex = 27;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(741, 30);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 26;
            label6.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 118);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 23;
            label3.Text = "C$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 22;
            label2.Text = "Motivo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 185);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 21;
            label1.Text = "Carnet";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(788, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // textCarnet
            // 
            textCarnet.Location = new Point(107, 178);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(272, 27);
            textCarnet.TabIndex = 16;
            // 
            // dgStudents
            // 
            dgStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudents.Location = new Point(29, 271);
            dgStudents.Name = "dgStudents";
            dgStudents.RowHeadersWidth = 51;
            dgStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudents.Size = new Size(1009, 188);
            dgStudents.TabIndex = 15;
            dgStudents.CellContentDoubleClick += dgStudents_CellContentDoubleClick;
            // 
            // textCordobas
            // 
            textCordobas.Location = new Point(107, 111);
            textCordobas.Name = "textCordobas";
            textCordobas.Size = new Size(272, 27);
            textCordobas.TabIndex = 29;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(871, 228);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 30;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(871, 193);
            button2.Name = "button2";
            button2.Size = new Size(167, 29);
            button2.TabIndex = 31;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboMotive
            // 
            comboMotive.AutoCompleteCustomSource.AddRange(new string[] { "Matricula", "Aranceles", "Biblioteca", "Constancia de dotas" });
            comboMotive.AutoCompleteMode = AutoCompleteMode.Append;
            comboMotive.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboMotive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMotive.FormattingEnabled = true;
            comboMotive.Items.AddRange(new object[] { "Matricula", "Aranceles", "Biblioteca", "Constancia de notas", "Otros..." });
            comboMotive.Location = new Point(107, 56);
            comboMotive.Name = "comboMotive";
            comboMotive.Size = new Size(298, 28);
            comboMotive.TabIndex = 32;
            // 
            // PaymentsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 500);
            Controls.Add(comboMotive);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textCordobas);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textCarnet);
            Controls.Add(dgStudents);
            Name = "PaymentsView";
            Text = "PaymentsView";
            Load += PaymentsView_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegister;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textCarnet;
        private DataGridView dgStudents;
        private TextBox textCordobas;
        private Button button1;
        private Button button2;
        private ComboBox comboMotive;
    }
}