﻿namespace Labdefense.Views
{
    partial class StudentsView
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
            dgPrint = new DataGridView();
            button1 = new Button();
            textSearch = new TextBox();
            btnDelete = new Button();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPrint).BeginInit();
            SuspendLayout();
            // 
            // dgPrint
            // 
            dgPrint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgPrint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPrint.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgPrint.BackgroundColor = Color.Lavender;
            dgPrint.BorderStyle = BorderStyle.None;
            dgPrint.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgPrint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPrint.Location = new Point(26, 157);
            dgPrint.Name = "dgPrint";
            dgPrint.RowHeadersWidth = 51;
            dgPrint.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPrint.Size = new Size(1006, 612);
            dgPrint.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(157, 36);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(26, 38);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(125, 27);
            textSearch.TabIndex = 2;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(935, 122);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(835, 122);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(735, 122);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Export";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StudentsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 817);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnDelete);
            Controls.Add(textSearch);
            Controls.Add(button1);
            Controls.Add(dgPrint);
            Name = "StudentsView";
            Text = "StudentsView";
            Load += StudentsView_Load;
            ((System.ComponentModel.ISupportInitialize)dgPrint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPrint;
        private Button button1;
        private TextBox textSearch;
        private Button btnDelete;
        private Button button3;
        private Button button2;
    }
}