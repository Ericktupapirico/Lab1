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
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(944, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // texName
            // 
            texName.Location = new Point(172, 89);
            texName.Name = "texName";
            texName.Size = new Size(171, 27);
            texName.TabIndex = 1;
            // 
            // textNum
            // 
            textNum.Location = new Point(520, 159);
            textNum.Name = "textNum";
            textNum.Size = new Size(183, 27);
            textNum.TabIndex = 2;
            // 
            // textIdentification
            // 
            textIdentification.Location = new Point(520, 89);
            textIdentification.Name = "textIdentification";
            textIdentification.Size = new Size(183, 27);
            textIdentification.TabIndex = 3;
            // 
            // textPar2
            // 
            textPar2.Location = new Point(800, 159);
            textPar2.Name = "textPar2";
            textPar2.Size = new Size(100, 27);
            textPar2.TabIndex = 4;
            textPar2.KeyPress += textPar2_KeyPress;
            // 
            // textSurname
            // 
            textSurname.Location = new Point(172, 159);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(171, 27);
            textSurname.TabIndex = 5;
            // 
            // textPro
            // 
            textPro.Location = new Point(800, 246);
            textPro.Name = "textPro";
            textPro.Size = new Size(100, 27);
            textPro.TabIndex = 6;
            textPro.TextChanged += textPro_TextChanged;
            textPro.KeyPress += textPro_KeyPress;
            // 
            // texPar1
            // 
            texPar1.Location = new Point(800, 89);
            texPar1.Name = "texPar1";
            texPar1.Size = new Size(100, 27);
            texPar1.TabIndex = 7;
            texPar1.KeyPress += texPar1_KeyPress;
            // 
            // textCarnet
            // 
            textCarnet.Location = new Point(172, 246);
            textCarnet.Name = "textCarnet";
            textCarnet.Size = new Size(171, 27);
            textCarnet.TabIndex = 9;
            textCarnet.TextChanged += textBox9_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(520, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // textTest
            // 
            textTest.Location = new Point(969, 89);
            textTest.Name = "textTest";
            textTest.Size = new Size(100, 27);
            textTest.TabIndex = 11;
            textTest.KeyPress += textTest_KeyPress;
            // 
            // UpdateView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 404);
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
    }
}