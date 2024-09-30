using Labdefense.Entity;
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
using static System.Net.Mime.MediaTypeNames;

namespace Labdefense.Views
{

    public partial class UpdateView : Form

    {
        private readonly Validations validations;
        public event Action OnDataUpdate = delegate { };
        private readonly Student student;
        public UpdateView(Student _student)
        {
            InitializeComponent();
            student = _student;
            UpdateInformation();
            validations = new Validations();
   
        }
        public void UpdateInformation()
        {
            if (student != null)
            {
                texName.Text = student.Name;
                textSurname.Text = student.Surname;
                textCarnet.Text = student.Carnet;
                dateTimePicker1.Value = student.DateRegister ?? DateTime.Now;
                textNum.Text = student.Number;
                texPar1.Text = student.IPar.ToString();
                textPar2.Text = student.IIPar.ToString();
                textPro.Text = student.Project.ToString();
                textIdentification.Text = student.Identification;
                textTest.Text = student.Test.ToString();
            }
        }
  
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = [textCarnet, textNum, textSurname, texName, textIdentification, texPar1, textPar2, textPro, textTest];
            TextBox[] textBid = [textIdentification];
            TextBox[] _textCarnet = [textCarnet];

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
            if (student != null)
            {
                student.Name = texName.Text;
                student.Surname = textSurname.Text;
                student.Carnet = textCarnet.Text;
                student.DateRegister = dateTimePicker1.Value;
                student.Number = textNum.Text;
                student.IPar = float.Parse(texPar1.Text);
                student.IIPar = float.Parse(textPar2.Text);
                student.Project = float.Parse(textPro.Text);
                student.Identification = textIdentification.Text;
                student.Test = float.Parse(textTest.Text);

            }
            OnDataUpdate?.Invoke();
            this.Close();
        }

   
    }
}
