using Labdefense.Models;
using Labdefense.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Labdefense.Views
{
    public partial class RegisterView : Form
    {
        private Validations validations;

        public Student? students;
        public RegisterView()
        {
            InitializeComponent();
            validations = new Validations();
            errorProvider1 = new ErrorProvider();

        }

        private void PrintStudents()
        {
            dgStudents.DataSource = null;
            dgStudents.DataSource = ArrayLogic.Arraylog.GetStudents();



            dgStudents.Columns["IPar"].Visible = false;

            dgStudents.Columns["IIPar"].Visible = false;

            dgStudents.Columns["project"].Visible = false;
            dgStudents.Columns["Finalgrades"].Visible = false;
            dgStudents.Columns["test"].Visible = false;
        }


        void RegisterStudents()
        {


            Student student = new Student
            {

                Name = textName.Text,
                Surname = textSurname.Text,
                Number = textNumMask.Text,
                Carnet = textCarnet.Text,
                Identification = textIdentification.Text,
                DateRegister = dateTimePicker1.Value,


            };

            ArrayLogic.Arraylog.AddStudent(student);

        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            PrintStudents();
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = { textCarnet, textSurname, textName, textIdentification };
            TextBox[] textBid = { textIdentification };
            TextBox[] _textCarnet = { textCarnet };

            if (validations.IsValidCarnet(_textCarnet))
            {
                MessageBox.Show("Por favor, ingrese un carnet valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validations.IsValidId(textBid))
            {
                MessageBox.Show("Por favor, ingrese un id valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validations.TextNullEmpty(textBoxes))
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!textNumMask.MaskFull)
            {
                errorProvider1.SetError(textNumMask, "Numero incompleto");
                return;
            }

            RegisterStudents();
            PrintStudents();


        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {


        }

        private void dgStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
