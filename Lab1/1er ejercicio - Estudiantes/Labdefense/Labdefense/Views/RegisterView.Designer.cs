using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgStudents = new DataGridView();
            textName = new TextBox();
            textSurname = new TextBox();
            textIdentification = new TextBox();
            textCarnet = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegister = new Button();
            textNumMask = new MaskedTextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgStudents
            // 
            dgStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgStudents.BackgroundColor = Color.LightCoral;
            dgStudents.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgStudents.GridColor = Color.Bisque;
            dgStudents.Location = new Point(12, 288);
            dgStudents.Name = "dgStudents";
            dgStudents.RowHeadersWidth = 51;
            dgStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudents.Size = new Size(1064, 356);
            dgStudents.TabIndex = 0;
       
            // 
            // textName
            // 
            textName.BackColor = SystemColors.Info;
            textName.Location = new Point(88, 59);
            textName.Name = "textName";
            textName.Size = new Size(286, 27);
            textName.TabIndex = 1;
     
            // 
            // textSurname
            // 
            textSurname.BackColor = SystemColors.Info;
            textSurname.Location = new Point(88, 115);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(286, 27);
            textSurname.TabIndex = 2;
            // 
            // textIdentification
            // 
            textIdentification.BackColor = SystemColors.Info;
            textIdentification.Location = new Point(582, 115);
            textIdentification.Name = "textIdentification";
            textIdentification.Size = new Size(314, 27);
            textIdentification.TabIndex = 3;
            // 
            // textCarnet
            // 
            textCarnet.BackColor = SystemColors.Info;
            textCarnet.Location = new Point(582, 59);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(314, 27);
            textCarnet.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Location = new Point(582, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 62);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(14, 118);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(18, 177);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(524, 62);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "Carnet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(479, 118);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 11;
            label5.Text = "Identification";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(526, 180);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 12;
            label6.Text = "Date";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.BackgroundImage = Properties.Resources.buttonsave;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Location = new Point(1043, 253);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(33, 29);
            btnRegister.TabIndex = 13;
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += BtnRegister_Click;
            // 
            // textNumMask
            // 
            textNumMask.BackColor = SystemColors.Info;
            textNumMask.Location = new Point(88, 170);
            textNumMask.Mask = "0000-0000";
            textNumMask.Name = "textNumMask";
            textNumMask.Size = new Size(77, 27);
            textNumMask.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 89);
            ClientSize = new Size(1088, 656);
            Controls.Add(textNumMask);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textCarnet);
            Controls.Add(textIdentification);
            Controls.Add(textSurname);
            Controls.Add(textName);
            Controls.Add(dgStudents);
            Name = "RegisterView";
            Text = "RegisterView";
            Load += RegisterView_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgStudents;
        private TextBox textName;
        private TextBox textSurname;
        private TextBox textIdentification;
        private TextBox textCarnet;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegister;
        private MaskedTextBox textNumMask;
        private ErrorProvider errorProvider1;
    }
}