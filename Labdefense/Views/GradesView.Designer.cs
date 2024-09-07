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
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            textSearch = new TextBox();
            btnSave = new Button();
            textP1 = new TextBox();
            textPar2 = new TextBox();
            textPro = new TextBox();
            textTest = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(925, 228);
            dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(192, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(43, 50);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(125, 27);
            textSearch.TabIndex = 5;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(657, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textP1
            // 
            textP1.Location = new Point(28, 153);
            textP1.Name = "textP1";
            textP1.Size = new Size(125, 27);
            textP1.TabIndex = 7;
         
            // 
            // textPar2
            // 
            textPar2.Location = new Point(192, 153);
            textPar2.Name = "textPar2";
            textPar2.Size = new Size(125, 27);
            textPar2.TabIndex = 8;
         
            // 
            // textPro
            // 
            textPro.Location = new Point(343, 153);
            textPro.Name = "textPro";
            textPro.Size = new Size(125, 27);
            textPro.TabIndex = 9;
           
            // 
            // textTest
            // 
            textTest.Location = new Point(503, 153);
            textTest.Name = "textTest";
            textTest.Size = new Size(125, 27);
            textTest.TabIndex = 10;
        
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GradesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 555);
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
    }
}