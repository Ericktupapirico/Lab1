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
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }
        private void PrintStudents()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ArrayLogicPayments.ArraylogPay.GetPayments();



        }


        private void ReportView_Load(object sender, EventArgs e)
        {
            PrintStudents();
        }
    }
}
