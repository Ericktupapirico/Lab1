namespace AEDLaboratorio2.Views
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            MenuItemChurch = new ToolStripMenuItem();
            MenuItemDentalClinic = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemChurch, MenuItemDentalClinic });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemChurch
            // 
            MenuItemChurch.Font = new Font("Segoe UI", 11.25F);
            MenuItemChurch.Name = "MenuItemChurch";
            MenuItemChurch.Size = new Size(120, 24);
            MenuItemChurch.Text = "Diezmo Iglesia";
            MenuItemChurch.Click += MenuItemChurch_Click;
            // 
            // MenuItemDentalClinic
            // 
            MenuItemDentalClinic.Font = new Font("Segoe UI", 11.25F);
            MenuItemDentalClinic.Name = "MenuItemDentalClinic";
            MenuItemDentalClinic.Size = new Size(161, 24);
            MenuItemDentalClinic.Text = "Clínica Odontológica";
            MenuItemDentalClinic.Click += MenuItemDentalClinic_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AED Laboratorio #2";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemChurch;
        private ToolStripMenuItem MenuItemDentalClinic;
    }
}
