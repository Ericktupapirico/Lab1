namespace Labdefense.Views
{
    partial class GradesView
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
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            textSearch = new TextBox();
            btnSave = new Button();
            textP1 = new TextBox();
            textPar2 = new TextBox();
            textPro = new TextBox();
            textTest = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.LightCoral;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Bisque;
            dataGridView1.Location = new Point(28, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(925, 511);
            dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.buttonsearch;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Location = new Point(174, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(29, 29);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.BackColor = SystemColors.Info;
            textSearch.Location = new Point(43, 50);
            textSearch.MaxLength = 15;
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(125, 27);
            textSearch.TabIndex = 5;
            textSearch.TextChanged += TextSearch_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.buttonsave;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new Point(920, 200);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(33, 29);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // textP1
            // 
            textP1.BackColor = SystemColors.Info;
            textP1.Location = new Point(28, 153);
            textP1.MaxLength = 2;
            textP1.Name = "textP1";
            textP1.Size = new Size(125, 27);
            textP1.TabIndex = 7;
            // 
            // textPar2
            // 
            textPar2.BackColor = SystemColors.Info;
            textPar2.Location = new Point(235, 154);
            textPar2.MaxLength = 2;
            textPar2.Name = "textPar2";
            textPar2.Size = new Size(125, 27);
            textPar2.TabIndex = 8;
            // 
            // textPro
            // 
            textPro.BackColor = SystemColors.Info;
            textPro.Location = new Point(447, 153);
            textPro.MaxLength = 2;
            textPro.Name = "textPro";
            textPro.Size = new Size(125, 27);
            textPro.TabIndex = 9;
            // 
            // textTest
            // 
            textTest.BackColor = SystemColors.Info;
            textTest.Location = new Point(684, 151);
            textTest.MaxLength = 2;
            textTest.Name = "textTest";
            textTest.Size = new Size(125, 27);
            textTest.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(366, 158);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 24;
            label9.Text = "/30 II Par";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(578, 156);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 23;
            label8.Text = "/20 Proyecto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(815, 154);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 22;
            label7.Text = "/20 Pruebas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(159, 156);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 21;
            label6.Text = "/30 I Par";
            // 
            // GradesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 89);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1033, 777);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textTest);
            Controls.Add(textPro);
            Controls.Add(textPar2);
            Controls.Add(textP1);
            Controls.Add(btnSave);
            Controls.Add(textSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "GradesView";
            Text = "GradesView";
            Load += GradesView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox textSearch;
        private Button btnSave;
        private TextBox textP1;
        private TextBox textPar2;
        private TextBox textPro;
        private TextBox textTest;
        private ErrorProvider errorProvider1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}