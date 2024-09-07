using Labdefense.Models;
using Labdefense.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labdefense.Views
{
    public partial class RegisterView : Form
    {
        private StudentsManager studentsManager;

        public Student[] students;
        public RegisterView()
        {
            InitializeComponent();
            this.students = students;
            studentsManager = new StudentsManager(students);
           

        }



        void RegisterStudents()
        {


            Student student = new Student()
            {
                id = studentsManager.GetNextId(),
                name = textName.Text,
                surname = textSurname.Text,
                Number = textNum.Text,
                carnet = textCarnet.Text,
                identifiaction = textIdentification.Text,
                dateRegister = dateTimePicker1.Value
                
            };

            studentsManager.AddStudent(student);

            MessageBox.Show("Persona Ingresada Correctamente");



        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStudents();

            dgStudents.DataSource = null;
            dgStudents.DataSource = studentsManager.GetStudents();
            dgStudents.Columns["IPar"].Visible = false;
            dgStudents.Columns["IIPar"].Visible = false;
            dgStudents.Columns["project"].Visible = false;
           
            
           
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
