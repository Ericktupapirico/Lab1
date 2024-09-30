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

namespace Labdefense.Views
{
    public partial class GradesView : Form
    {
        private Validations validations;

        public GradesView()
        {
            InitializeComponent();
            validations = new Validations();
            textP1.KeyPress += new KeyPressEventHandler(validations.ValidateNumberInput);
            textPar2.KeyPress += new KeyPressEventHandler(validations.ValidateNumberInput);
            textPro.KeyPress += new KeyPressEventHandler(validations.ValidateNumberInput);
            textTest.KeyPress += new KeyPressEventHandler(validations.ValidateNumberInput);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Carnet = textSearch.Text;
            var _students = ArrayLogic.Arraylog.SearchStudentByCarnet(Carnet);

            if (_students.Length > 0)
            {
                dataGridView1.DataSource = _students;
            }
            else
            {
                MessageBox.Show("No se encontro al estudiante con carnet:" + Carnet, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void PrintStudents()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ArrayLogic.Arraylog.GetStudents();



            dataGridView1.Columns["identification"].Visible = false;

            dataGridView1.Columns["Number"].Visible = false;

            dataGridView1.Columns["dateRegister"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var IndexSelectDg = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[IndexSelectDg].DataBoundItem is not Student studentselect)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(studentselect.Carnet))
            {
                MessageBox.Show("No se ha encontrado el carnet estudiantil", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            TextBox[] textBoxes = { textPar2, textP1, textTest, textPro };
            if (validations.TextNullEmpty(textBoxes))
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            studentselect.IPar = float.Parse(textP1.Text);
            studentselect.IIPar = float.Parse(textPar2.Text);
            studentselect.Project = float.Parse(textPro.Text);
            studentselect.Test = float.Parse(textTest.Text);
            studentselect.Finalgrades = studentselect.finalgrades();
            ArrayLogic.Arraylog.SaveGrades(studentselect);
            PrintStudents();


        }

        private void GradesView_Load(object sender, EventArgs e)
        {
            PrintStudents();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {


            PrintStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
