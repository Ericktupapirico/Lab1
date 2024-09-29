using Labdefense.Models;
using Labdefense.Views;

namespace Labdefense
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void OpenForms(Form form)
        {
            while (PanelFather.Controls.Count > 0)
            {
                PanelFather.Controls.RemoveAt(0);
            }
            Form formHijo = form;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelFather.Controls.Add(formHijo);
            formHijo.Show();
        }


        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxim.Visible = false;
            btnNormal.Visible = true;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxim.Visible = true;
            btnNormal.Visible = false;

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
         OpenForms(new RegisterView());
        }

        private void BtnGrades_Click(object sender, EventArgs e)
        {
            OpenForms(form: new GradesView());
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            OpenForms(form: new PaymentsView());
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            OpenForms(form: new ReportView());
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            OpenForms(form: new StudentsView());
        }
    }
}
