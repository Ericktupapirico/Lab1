﻿using Labdefense.Entity;
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
    public partial class StudentsView : Form
    {
        private readonly ExportToExcel ExportToExcel;
        public Student[]? students;
        public StudentsView()
        {

            InitializeComponent();
            ExportToExcel = new ExportToExcel();

        }
        private void PrintStudents()
        {
            dgPrint.DataSource = null;
            dgPrint.DataSource = ArrayLogic.Arraylog.GetStudents();


        }

        private void StudentsView_Load(object sender, EventArgs e)
        {
            PrintStudents();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (dgPrint.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var IndexSelectDg = dgPrint.SelectedRows[0].Index;
            if (dgPrint.Rows[IndexSelectDg].DataBoundItem is not Student studentselect)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(studentselect.Carnet))
            {
                MessageBox.Show("No se ha encontrado el carnet estudiantil", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var resulMessage = MessageBox.Show("Seguro que quiere eliminar a " + studentselect.Name + " " + studentselect.Surname, "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resulMessage == DialogResult.No)
            {
                return;
            }
            ArrayLogic.Arraylog.RemoveStudent(studentselect.Carnet);
            dgPrint.DataSource = null;
            dgPrint.DataSource = ArrayLogic.Arraylog.GetStudents();
        }

        private void Button3_Click(object sender, EventArgs e)

        {

            if (dgPrint.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var IndexSelectDg = dgPrint.SelectedRows[0].Index;
            if (dgPrint.Rows[IndexSelectDg].DataBoundItem is not Student studentselect)
            {
                MessageBox.Show("No se seleccionado un estudiante", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateView updateView = new(studentselect);
            updateView.OnDataUpdate += PrintStudents;
            updateView.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Carnet = textSearch.Text;
            var _students = ArrayLogic.Arraylog.SearchStudentByCarnet(Carnet);

            if (_students.Length > 0)
            {
                dgPrint.DataSource = _students;
            }
            else
            {
                MessageBox.Show("No se encontro al estudiante con carnet:" + Carnet, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

      

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new()
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                FileName = "Studets.xlsx"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel.ExportCloseXml(dgPrint, dlg.FileName);
                MessageBox.Show("Datos exportados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
