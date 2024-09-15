namespace Labdefense
{
    partial class Form1
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
            panel1 = new Panel();
            btnNormal = new Button();
            btnMin = new Button();
            btnMaxim = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            panel8 = new Panel();
            btnStudents = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            btnReports = new Button();
            panel6 = new Panel();
            btnPayments = new Button();
            panel5 = new Panel();
            btnGrades = new Button();
            panel4 = new Panel();
            btnRegister = new Button();
            PanelFather = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnNormal);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnMaxim);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 48);
            panel1.TabIndex = 0;
            // 
            // btnNormal
            // 
            btnNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNormal.BackgroundImage = Properties.Resources.normal;
            btnNormal.BackgroundImageLayout = ImageLayout.Stretch;
            btnNormal.Cursor = Cursors.Hand;
            btnNormal.FlatAppearance.BorderSize = 0;
            btnNormal.FlatStyle = FlatStyle.Flat;
            btnNormal.Location = new Point(1212, 7);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(35, 35);
            btnNormal.TabIndex = 1;
            btnNormal.UseVisualStyleBackColor = true;
            btnNormal.Visible = false;
            btnNormal.Click += button4_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackgroundImage = Properties.Resources.min;
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.Cursor = Cursors.Hand;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(1171, 7);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(35, 35);
            btnMin.TabIndex = 1;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMaxim
            // 
            btnMaxim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaxim.BackgroundImage = Properties.Resources.maxim2;
            btnMaxim.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaxim.Cursor = Cursors.Hand;
            btnMaxim.FlatAppearance.BorderSize = 0;
            btnMaxim.FlatStyle = FlatStyle.Flat;
            btnMaxim.Location = new Point(1212, 7);
            btnMaxim.Name = "btnMaxim";
            btnMaxim.Size = new Size(35, 35);
            btnMaxim.TabIndex = 2;
            btnMaxim.UseVisualStyleBackColor = true;
            btnMaxim.Click += btnMaxim_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackgroundImage = Properties.Resources.cerrrar;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1253, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(btnStudents);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(btnReports);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnPayments);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnGrades);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnRegister);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 602);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.RoyalBlue;
            panel8.Location = new Point(0, 463);
            panel8.Name = "panel8";
            panel8.Size = new Size(14, 44);
            panel8.TabIndex = 12;
            // 
            // btnStudents
            // 
            btnStudents.BackgroundImageLayout = ImageLayout.Center;
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = Color.White;
            btnStudents.Image = Properties.Resources.clientes;
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(12, 463);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(237, 44);
            btnStudents.TabIndex = 11;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(224, 16);
            label2.TabIndex = 10;
            label2.Text = "Universidad Nacional De Ingenieraria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(74, 86);
            label1.Name = "label1";
            label1.Size = new Size(71, 47);
            label1.TabIndex = 9;
            label1.Text = "UNI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(74, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.Location = new Point(0, 399);
            panel7.Name = "panel7";
            panel7.Size = new Size(14, 44);
            panel7.TabIndex = 7;
            // 
            // btnReports
            // 
            btnReports.BackgroundImageLayout = ImageLayout.Center;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Image = Properties.Resources.reportes;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(12, 399);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(237, 44);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.RoyalBlue;
            panel6.Location = new Point(0, 331);
            panel6.Name = "panel6";
            panel6.Size = new Size(14, 44);
            panel6.TabIndex = 5;
            // 
            // btnPayments
            // 
            btnPayments.BackgroundImageLayout = ImageLayout.Center;
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.Image = Properties.Resources.pagos;
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(12, 331);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(237, 44);
            btnPayments.TabIndex = 4;
            btnPayments.Text = "Payments";
            btnPayments.UseVisualStyleBackColor = true;
            btnPayments.Click += btnPayments_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Location = new Point(0, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(14, 44);
            panel5.TabIndex = 3;
            // 
            // btnGrades
            // 
            btnGrades.BackgroundImageLayout = ImageLayout.Center;
            btnGrades.Cursor = Cursors.Hand;
            btnGrades.FlatAppearance.BorderSize = 0;
            btnGrades.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnGrades.FlatStyle = FlatStyle.Flat;
            btnGrades.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrades.ForeColor = Color.White;
            btnGrades.Image = Properties.Resources.empleados;
            btnGrades.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrades.Location = new Point(12, 260);
            btnGrades.Name = "btnGrades";
            btnGrades.Size = new Size(237, 44);
            btnGrades.TabIndex = 2;
            btnGrades.Text = "Grades";
            btnGrades.UseVisualStyleBackColor = true;
            btnGrades.Click += btnGrades_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(0, 184);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 44);
            panel4.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.BackgroundImageLayout = ImageLayout.Center;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Image = Properties.Resources.producto21;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(12, 184);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(237, 44);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // PanelFather
            // 
            PanelFather.BackColor = Color.FromArgb(49, 66, 89);
            PanelFather.BackgroundImage = Properties.Resources.logo3;
            PanelFather.BackgroundImageLayout = ImageLayout.Center;
            PanelFather.Dock = DockStyle.Fill;
            PanelFather.Location = new Point(249, 48);
            PanelFather.Name = "PanelFather";
            PanelFather.Size = new Size(1051, 602);
            PanelFather.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PanelFather);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Register Students Lab 2M1-CO";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel PanelFather;
        private Button btnClose;
        private Button btnMin;
        private Button btnMaxim;
        private Button btnNormal;
        private Panel panel4;
        private Button btnRegister;
        private Panel panel7;
        private Button btnReports;
        private Panel panel6;
        private Button btnPayments;
        private Panel panel5;
        private Button btnGrades;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel8;
        private Button btnStudents;
    }
}
