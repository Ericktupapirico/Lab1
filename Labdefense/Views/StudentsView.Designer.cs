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
            dgPrint = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPrint).BeginInit();
            SuspendLayout();
            // 
            // dgPrint
            // 
            dgPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPrint.Location = new Point(26, 198);
            dgPrint.Name = "dgPrint";
            dgPrint.RowHeadersWidth = 51;
            dgPrint.Size = new Size(738, 188);
            dgPrint.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(670, 41);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgPrint);
            Name = "StudentsView";
            Text = "StudentsView";
            ((System.ComponentModel.ISupportInitialize)dgPrint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPrint;
        private Button button1;
    }
}