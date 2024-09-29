using Labdefense.Entity;
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

    public partial class PaymentsView : Form
    {
        private readonly Validations validations;

   
        public PaymentsView()
        {
            InitializeComponent();
            validations = new Validations();
        
         

            comboMotive.SelectedIndex = 0;
            PrintStudents();
        }

        private int Quantity = 1;
        private void PrintStudents()
        {
            dgStudents.DataSource = null;
            dgStudents.DataSource = ArrayLogicPayments.ArraylogPay.GetPayments();

        }


       private void RegisterStudents()
        {

            string CarnetPayment = textCarnet.Text;
            Payments payment = new()
            {
                Cordobas = float.Parse(textCordobas.Text),
                Motive = comboMotive.Text,
                Carnet = CarnetPayment,
                DatePay = dateTimePicker1.Value,
                CantPayments = Quantity

            };

            ArrayLogicPayments.ArraylogPay.AddPayment(payment);

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = [textCarnet, textCordobas];
            TextBox[] textCarnetValid = [textCarnet];
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
            RegisterStudents();
            ++Quantity;
            PrintStudents();
        }
        private void PaymentsView_Load(object sender, EventArgs e)
        {
            PrintStudents();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (dgStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var IndexSelectDg = dgStudents.SelectedRows[0].Index;
            if (dgStudents.Rows[IndexSelectDg].DataBoundItem is not Payments studentselect)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(studentselect.Carnet))
            {
                MessageBox.Show("No se ha encontrado el carnet estudiantil", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var resulMessage = MessageBox.Show("Seguro que quiere eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resulMessage == DialogResult.No)
            {
                return;
            }
            ArrayLogicPayments.ArraylogPay.RemovePayment(studentselect.Carnet);
            dgStudents.DataSource = null;
            dgStudents.DataSource = ArrayLogicPayments.ArraylogPay.GetPayments();
            --Quantity;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (dgStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var IndexSelectDg = dgStudents.SelectedRows[0].Index;
            if (dgStudents.Rows[IndexSelectDg].DataBoundItem is not Payments studentselect)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdatePayView updateViewpay = new(studentselect);
            updateViewpay.OnDataUpdate += PrintStudents;
            updateViewpay.ShowDialog();

        }

        private void DgStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                }
            }
        }

    
