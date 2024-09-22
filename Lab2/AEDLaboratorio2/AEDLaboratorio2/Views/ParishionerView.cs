using AEDLaboratorio2.Entities.Church;
using AEDLaboratorio2.Models.Church;
using AEDLaboratorio2.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEDLaboratorio2.Views
{
    public partial class ParishionerView : Form
    {
        private readonly Validations validations;
        private Parishioner? _parishioner;
        /*
         * Instancia unica de la clase valifations para aplicar el metodo situado.
         * Instancia del objeto que guardaremos en el arreglo
         */
        public ParishionerView()
        {
            InitializeComponent();
            validations = new Validations();
            _parishioner = new Parishioner();
            //Pasamos las instancias en el constructor para su uso

        }
        int autoIncrementID = 0;//variable autoincrementable para tener el conteo de registros y mostrarlos en el datagridview y su previa busueda
        private void PrintParishioners()
        {
            dgPrintParishioner.DataSource = null;
            dgPrintParishioner.DataSource = ParishionerModel.arrayLogic.GetParisioner();//metodo para actualilzar el datagriview en funcion del arreglo
        }
        private void SaveParishioner()
        {
            _parishioner = new Parishioner
            {
                ID = ++autoIncrementID,
                Name = TxtName.Text,
                Address = TxtAddress.Text,
                PhoneNumber = TxtMaskPhone.Text,
                Amount = decimal.Parse(textCant.Text),
                PeriodStart = CmbPStart.Text,
                PeriodEnd = cmbPEnd.Text,
                DateRegister = DateTime.Now

            };
            ParishionerModel.arrayLogic.AddParishioner(_parishioner);//metodo para guardar a los feligrenses inicializando un nuevo feligrense y usadndo el metodo en models
        }
        private void UpdateParishioner(Parishioner parishioner)
        {

            var _parishionerUpdate = new Parishioner
            {
                ID = parishioner.ID,
                Name = TxtName.Text,
                Address = TxtAddress.Text,
                PhoneNumber = TxtMaskPhone.Text,
                Amount = decimal.Parse(textCant.Text),
                PeriodStart = CmbPStart.Text,
                PeriodEnd = cmbPEnd.Text,
                DateRegister = DateTime.Now

            };
            ParishionerModel.arrayLogic.UpdateParishioner(_parishionerUpdate);
            /*
             * Similar al metodo guardar pero este recibe el mismo id del usuario seleccionado y por medio del uso models 
             * se busca en el arreglo el indice con ese id y se actualiza la informacion
             */
        }
        public void ValidationsTools()
        {
            bool isValid = true;

            isValid &= validations.TextNullOrEmpty(TxtAddress);
            isValid &= validations.TextNullOrEmpty(TxtName);
            isValid &= validations.TextNullOrEmpty(TxtMaskPhone);
            isValid &= validations.TextNullOrEmpty(textCant);
            isValid &= validations.TextNullOrEmpty(CmbPStart);
            isValid &= validations.TextNullOrEmpty(cmbPEnd);

            if (!isValid)
            {
                MessageBox.Show("Information null or empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*
         * Validacion para los campos de texto nulos o invalidos, &= si el metodo retorna false, el booleano isvalid se vuelve false y salta la alerta
         */
        private void CleanBox()
        {
            TxtName.Text = textCant.Text = TxtMaskPhone.Text = TxtAddress.Text = string.Empty;
            CmbPStart.SelectedIndex = -1;
            cmbPEnd.SelectedIndex = -1;//funcionpara limpiar los campos de texto
        }
        private void ParishionerView_Load(object sender, EventArgs e)
        {
            PrintParishioners();//uso de una funcion
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidationsTools();//aplicacion del metodo validationstools y si uno falla no permite avanzar

            if (!validations.TextNullOrEmpty(TxtAddress) || !validations.TextNullOrEmpty(TxtName) ||
                !validations.TextNullOrEmpty(TxtMaskPhone) || !validations.TextNullOrEmpty(textCant) ||
                !validations.TextNullOrEmpty(CmbPStart) || !validations.TextNullOrEmpty(cmbPEnd))
            {
                return; // No proceder si hay errores de validación
            }

            SaveParishioner();
            PrintParishioners();//uso de funciones
            CleanBox();
        }


        private void BtnClearForm_Click(object sender, EventArgs e)
        {
            CleanBox();//uso de funciones
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {

            if (dgPrintParishioner.CurrentRow == null) return;

            var currentIndex = dgPrintParishioner.CurrentRow.Index;

            if (currentIndex > 0)
            {

                dgPrintParishioner.ClearSelection();

                dgPrintParishioner.Rows[currentIndex - 1].Selected = true;

                dgPrintParishioner.CurrentCell = dgPrintParishioner.Rows[currentIndex - 1].Cells[0];

            }

        }
        /*
         * Verifica si el indice es nulo y si el indice actual es mayor a 0, si es mayor a 0 retrocede una celda en el data gridview
         */

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (dgPrintParishioner.CurrentRow == null) return;
            var currentIndex = dgPrintParishioner.CurrentRow.Index;
            if (currentIndex < dgPrintParishioner.Rows.Count - 1)
            {
                dgPrintParishioner.ClearSelection();
                dgPrintParishioner.Rows[currentIndex + 1].Selected = true;
                dgPrintParishioner.CurrentCell = dgPrintParishioner.Rows[currentIndex + 1].Cells[0];
            }

        }
        /*
         * se repite el mismo proceso pero esta vez se verifica si el indice es menor a la cantidad de celdas en el dg, si esta 
         * hasta el tope no avanza, se caso contrario avanza una celda
         */
        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (dgPrintParishioner.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected. Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parishionerSelected = dgPrintParishioner.SelectedRows[0].DataBoundItem as Parishioner;
            if (parishionerSelected == null)
            {
                MessageBox.Show("Option selected doesn't exist or is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var dlgTest = MessageBox.Show("Are you sure delete: " + parishionerSelected.Name + " with ID : " + parishionerSelected.ID, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgTest == DialogResult.No) return;
            var proveDelete = ParishionerModel.arrayLogic.DeleteParishioner(parishionerSelected.ID);
            if (!proveDelete)
            {
                MessageBox.Show("Cannot delete parishioner : " + parishionerSelected.Name + " with ID : " + parishionerSelected.ID + "?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            PrintParishioners();
            CleanBox();
            btnSaveUpdate.Visible = false;
            BtnSave.Visible = true;
        }
        /*
         * Si no se ha seleccionado una celda muestra el mensaje de error, si no se obtiene la informacion de esa celda de tipo objeto pariishioner respectivamente se usa su id para buscar en el arreglo el objeto con ese id 
         * y eliminarlo
         */
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            PrintParishioners();//uso de funciones
        }



        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgPrintParishioner.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected. Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parishionerSelected = dgPrintParishioner.SelectedRows[0].DataBoundItem as Parishioner;
            if (parishionerSelected == null)
            {
                MessageBox.Show("Option selected doesn't exist or is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dlgTest = MessageBox.Show($"Are you sure you want to update: {parishionerSelected.Name} with ID: {parishionerSelected.ID}?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgTest == DialogResult.No) return;

            TxtName.Text = parishionerSelected.Name;
            TxtAddress.Text = parishionerSelected.Address;
            TxtMaskPhone.Text = parishionerSelected.PhoneNumber;
            dateTimeRegister.Value = parishionerSelected.DateRegister;
            CmbPStart.Text = parishionerSelected.PeriodStart;
            cmbPEnd.Text = parishionerSelected.PeriodEnd;
            textCant.Text = parishionerSelected.Amount.ToString();

            BtnPrevious.Enabled = false;
            BtnNext.Enabled = false;
            btnSaveUpdate.Visible = true;
            BtnSave.Visible = false;

        }
        /*
         * Se hace el mismo proceso que Delete pero cuando se encuentra al objeto con el id , se actualiza los campos de texto con la infromacion de ese usario y se bloquean los botones
         * de avanzar y retoroceder para evitar editar otro feligrense
         */

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (dgPrintParishioner.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected. Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var parishionerSelected = dgPrintParishioner.SelectedRows[0].DataBoundItem as Parishioner;
            if (parishionerSelected == null)
            {
                MessageBox.Show("Option selected doesn't exist or is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnPrevious.Enabled = true;
            BtnNext.Enabled = true;
            btnSaveUpdate.Visible = false;
            BtnSave.Visible = true;
            ValidationsTools();

            if (!validations.TextNullOrEmpty(TxtAddress) || !validations.TextNullOrEmpty(TxtName) ||
                !validations.TextNullOrEmpty(TxtMaskPhone) || !validations.TextNullOrEmpty(textCant) ||
                !validations.TextNullOrEmpty(CmbPStart) || !validations.TextNullOrEmpty(cmbPEnd))
            {
                return; // No proceder si hay errores de validación
            }
            UpdateParishioner(parishionerSelected);
            CleanBox();
            PrintParishioners();
            MessageBox.Show("Parishioner update sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /*
         * Se vuelve a validar si la celda seleccionada es valida y se manda a llamar el metodo actualizar, ahora con la informacion actualizada en los campos de text,
         * (Antes se habian rellenado los campos de texto con los datos del feligrense ubicado por su id para su respectiva edicion) se envia el id del feligrense y el metodo hace su accion
         */

        private void BtnSearchById_Click(object sender, EventArgs e)
        {
            int idParishioner = (int)TxtNumSearchID.Value;
            var specificParioshioner = ParishionerModel.arrayLogic.SearchParishioner(idParishioner);
            if (specificParioshioner == null)
            {
                MessageBox.Show("ID Doesn't Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            dgPrintParishioner.DataSource = new Parishioner[] { specificParioshioner };

        }
        /*
         * Se convierte a entero el valor recibido de numericuptodown debido que se requiere buscar el feligrense con ese id e imprimirlo en el datagridview, si no se 
         * encuentra se envia un mensaje de error
         */
        private void textCant_KeyPress(object sender, KeyPressEventArgs e)
        {

            char index = e.KeyChar;
            if (index == 8)
            {
                e.Handled = false;//permite backspace
                return;
            }
            if (!char.IsDigit(index))
            {
                e.Handled = true;//Permite solo numeros
                return;
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char index = e.KeyChar;
            if (index == 8)
            {
                e.Handled = false;//permite backspace
                return;
            }
            if (char.IsDigit(index))
            {
                e.Handled = true;//permite solo letras
                return;
            }
        }

    }
}
