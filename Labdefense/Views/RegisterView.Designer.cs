namespace Labdefense.Views
{
    partial class RegisterView
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
            dgStudents = new DataGridView();
            textName = new TextBox();
            textSurname = new TextBox();
            textIdentification = new TextBox();
            textNum = new TextBox();
            textCarnet = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudents).BeginInit();
            SuspendLayout();
            // 
            // dgStudents
            // 
            dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudents.Location = new Point(12, 288);
            dgStudents.Name = "dgStudents";
            dgStudents.RowHeadersWidth = 51;
            dgStudents.Size = new Size(1009, 188);
            dgStudents.TabIndex = 0;
            // 
            // textName
            // 
            textName.Location = new Point(116, 56);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 1;
            textName.TextChanged += textName_TextChanged;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(116, 112);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(125, 27);
            textSurname.TabIndex = 2;
            // 
            // textIdentification
            // 
            textIdentification.Location = new Point(455, 112);
            textIdentification.Name = "textIdentification";
            textIdentification.Size = new Size(125, 27);
            textIdentification.TabIndex = 3;
            // 
            // textNum
            // 
            textNum.Location = new Point(116, 174);
            textNum.Name = "textNum";
            textNum.Size = new Size(125, 27);
            textNum.TabIndex = 4;
            // 
            // textCarnet
            // 
            textCarnet.Location = new Point(455, 56);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(125, 27);
            textCarnet.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(455, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 59);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 115);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 174);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 9;
            label3.Text = "Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 59);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 10;
            label4.Text = "Carnet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 115);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 11;
            label5.Text = "Identification";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 177);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 12;
            label6.Text = "Date";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(674, 69);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(674, 115);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(125, 29);
            btnPrint.TabIndex = 14;
            btnPrint.Text = "Show Register";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 555);
            Controls.Add(btnPrint);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textCarnet);
            Controls.Add(textNum);
            Controls.Add(textIdentification);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(dgStudents);
            Name = "RegisterView";
            Text = "RegisterView";
            Load += RegisterView_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgStudents;
        private TextBox textName;
        private TextBox textSurname;
        private TextBox textIdentification;
        private TextBox textNum;
        private TextBox textCarnet;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private Button btnPrint;
    }
}