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
    public partial class StudentsView : Form
    {
        public Student[] students;
        public StudentsView(ref Student[] students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgPrint.DataSource = students;
        }
    }
}
