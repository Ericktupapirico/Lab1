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
    public partial class GradesView : Form
    {
        public Student[] students;
        public GradesView(ref Student[] students)
        {
            InitializeComponent();
        }
    }
}
