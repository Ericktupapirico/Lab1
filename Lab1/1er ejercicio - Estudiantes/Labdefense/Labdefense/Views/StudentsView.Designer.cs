namespace Labdefense.Views
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dgPrint.BackgroundColor = Color.LightCoral;
            dgPrint.BorderStyle = BorderStyle.None;
            dgPrint.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgPrint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPrint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPrint.DefaultCellStyle = dataGridViewCellStyle2;
            dgPrint.Location = new Point(26, 157);
            dgPrint.Name = "dgPrint";
            dgPrint.RowHeadersWidth = 51;
            dgPrint.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPrint.Size = new Size(1006, 612);
            dgPrint.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.buttonsearch;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(157, 38);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textSearch
            // 
            textSearch.BackColor = SystemColors.Info;
            textSearch.Location = new Point(26, 38);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(125, 27);
            textSearch.TabIndex = 2;
         
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackgroundImage = Properties.Resources.deletebotton1;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Location = new Point(1000, 122);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(32, 29);
            btnDelete.TabIndex = 3;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackgroundImage = Properties.Resources.updatebutton;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(962, 122);
            button3.Name = "button3";
            button3.Size = new Size(32, 29);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackgroundImage = Properties.Resources.excelicon;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(920, 122);
            button2.Name = "button2";
            button2.Size = new Size(36, 29);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // StudentsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 89);
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