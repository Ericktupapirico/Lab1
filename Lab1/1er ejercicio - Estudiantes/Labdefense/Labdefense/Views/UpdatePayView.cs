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
    public partial class UpdatePayView : Form
    {
        private Validations validations;
        public event Action OnDataUpdate;
        private Payments student;

        public UpdatePayView(Payments payments)
        {
            InitializeComponent();
            validations = new Validations();
            student = payments; 
            UpdateInformation(); 
        }

        public void UpdateInformation()
        {
            if (student != null)
            {
                textCarnet.Text = student.Carnet;
                textCordobas.Text = student.Cordobas.ToString();
                comboMotive.Text = student.Motive;
                dateTimePicker1.Value = student.DatePay;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { textCarnet, textCordobas };
            TextBox[] textCarnetValid = { textCarnet };
            if (validations.IsValidCarnet(textCarnetValid))
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validations.TextNullEmpty(textBoxes))
            {
                MessageBox.Show("Por favor, rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (student != null)
            {

                student.Carnet = textCarnet.Text;
                student.Cordobas = float.Parse(textCordobas.Text);
                student.Motive = comboMotive.Text;
                student.DatePay = dateTimePicker1.Value;
            }


            OnDataUpdate?.Invoke();
            this.Close();
        }
    }

}
