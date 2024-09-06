using Labdefense.Models;
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


        public RegisterView()
        {
            InitializeComponent();
        }

        Student[] students;
        int Quantity;

        void RegisterStudents()
        {


            Array.Resize(ref students, Quantity + 1);
            students[Quantity] = new Student();


            students[Quantity].name = textName.Text;
            students[Quantity].surname = textSurname.Text;
            students[Quantity].carnet = textCarnet.Text;
            students[Quantity].identifiaction = textIdentification.Text;
            students[Quantity].Number = textNum.Text;
            students[Quantity].dateRegister = dateTimePicker1.Value;
            students[Quantity].id = Quantity + 1;
            ++Quantity;


            MessageBox.Show("Persona Ingresada Correctamente");



        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterStudents();

           
            dgStudents.DataSource = students;
            dgStudents.Columns["IPar"].Visible = false;
            dgStudents.Columns["IIPar"].Visible = false;
            dgStudents.Columns["project"].Visible = false;
            Form1 form1 = new Form1(ref students);

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
