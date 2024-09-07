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
    public partial class StudentsView : Form
    {
        private StudentsManager studentsManager;
        public StudentsView()
        {
            InitializeComponent();
            studentsManager = new StudentsManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgPrint.DataSource = null; 
          dgPrint.DataSource =  studentsManager.GetStudents();
        }
    }
}
