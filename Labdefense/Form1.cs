using Labdefense.Models;
using Labdefense.Views;

namespace Labdefense
{
    public partial class Form1 : Form
    {
        private Student[] students;
        public Form1()
        {
            InitializeComponent();

            students = new Student[] { };
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
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelFather.Controls.Add(formHijo);
            formHijo.Show();
        }
        public void UpdateStudents(Student[] updatedStudents)
        {
            students = updatedStudents;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxim.Visible = false;
            btnNormal.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxim.Visible = true;
            btnNormal.Visible = false;

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)

        {



            OpenForms(new RegisterView());
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            OpenForms(form: new GradesView());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            OpenForms(form: new PaymentsView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenForms(form: new ReportView());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenForms(form: new StudentsView());
        }
    }
}
