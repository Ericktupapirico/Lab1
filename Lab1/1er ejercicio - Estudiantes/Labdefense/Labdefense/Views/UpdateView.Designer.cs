namespace Labdefense.Views
{
    partial class UpdateView
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
            btnUpdate = new Button();
            texName = new TextBox();
            textNum = new TextBox();
            textIdentification = new TextBox();
            textPar2 = new TextBox();
            textSurname = new TextBox();
            textPro = new TextBox();
            texPar1 = new TextBox();
            textCarnet = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textTest = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = Properties.Resources.updatebutton1;
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.Location = new Point(861, 316);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(39, 36);
            btnUpdate.TabIndex = 0;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // texName
            // 
            texName.BackColor = SystemColors.Info;
            texName.Location = new Point(172, 89);
            texName.Name = "texName";
            texName.Size = new Size(171, 27);
            texName.TabIndex = 1;
            texName.TextChanged += texName_TextChanged;
            // 
            // textNum
            // 
            textNum.BackColor = SystemColors.Info;
            textNum.Location = new Point(520, 159);
            textNum.Name = "textNum";
            textNum.Size = new Size(183, 27);
            textNum.TabIndex = 2;
            // 
            // textIdentification
            // 
            textIdentification.BackColor = SystemColors.Info;
            textIdentification.Location = new Point(520, 89);
            textIdentification.Name = "textIdentification";
            textIdentification.Size = new Size(183, 27);
            textIdentification.TabIndex = 3;
            // 
            // textPar2
            // 
            textPar2.BackColor = SystemColors.Info;
            textPar2.Location = new Point(800, 149);
            textPar2.Name = "textPar2";
            textPar2.Size = new Size(100, 27);
            textPar2.TabIndex = 4;
            textPar2.KeyPress += textPar2_KeyPress;
            // 
            // textSurname
            // 
            textSurname.BackColor = SystemColors.Info;
            textSurname.Location = new Point(172, 159);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(171, 27);
            textSurname.TabIndex = 5;
            // 
            // textPro
            // 
            textPro.BackColor = SystemColors.Info;
            textPro.Location = new Point(800, 207);
            textPro.Name = "textPro";
            textPro.Size = new Size(100, 27);
            textPro.TabIndex = 6;
            textPro.TextChanged += textPro_TextChanged;
            textPro.KeyPress += textPro_KeyPress;
            // 
            // texPar1
            // 
            texPar1.BackColor = SystemColors.Info;
            texPar1.Location = new Point(800, 89);
            texPar1.Name = "texPar1";
            texPar1.Size = new Size(100, 27);
            texPar1.TabIndex = 7;
            texPar1.KeyPress += texPar1_KeyPress;
            // 
            // textCarnet
            // 
            textCarnet.BackColor = SystemColors.Info;
            textCarnet.Location = new Point(172, 246);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(171, 27);
            textCarnet.TabIndex = 9;
            textCarnet.TextChanged += textBox9_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.Location = new Point(520, 234);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // textTest
            // 
            textTest.BackColor = SystemColors.Info;
            textTest.Location = new Point(800, 269);
            textTest.Name = "textTest";
            textTest.Size = new Size(100, 27);
            textTest.TabIndex = 11;
            textTest.KeyPress += textTest_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(95, 92);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(447, 159);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 13;
            label2.Text = "Numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(410, 92);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 14;
            label3.Text = "Identificacion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(107, 249);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 15;
            label4.Text = "Carnet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(95, 166);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 16;
            label5.Text = "Apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(906, 92);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 17;
            label6.Text = "/30 I Par";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(906, 272);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 18;
            label7.Text = "/20 Pruebas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(906, 214);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 19;
            label8.Text = "/30 Proyecto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(906, 152);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 20;
            label9.Text = "/30 II Par";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(461, 239);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 21;
            label10.Text = "Fecha:";
            // 
            // UpdateView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 89);
            ClientSize = new Size(1095, 404);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textTest);
            Controls.Add(dateTimePicker1);
            Controls.Add(textCarnet);
            Controls.Add(texPar1);
            Controls.Add(textPro);
            Controls.Add(textSurname);
            Controls.Add(textPar2);
            Controls.Add(textIdentification);
            Controls.Add(textNum);
            Controls.Add(texName);
            Controls.Add(btnUpdate);
            Name = "UpdateView";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox texName;
        private TextBox textNum;
        private TextBox textIdentification;
        private TextBox textPar2;
        private TextBox textSurname;
        private TextBox textPro;
        private TextBox texPar1;
        private TextBox textCarnet;
        private DateTimePicker dateTimePicker1;
        private TextBox textTest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}