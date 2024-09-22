using AEDLaboratorio2.Models.Church;

namespace AEDLaboratorio2.Views
{
    public partial class FrmChurch : Form
    {
        private readonly ParishionerModel _parishionerModel;

        public FrmChurch()
        {
            InitializeComponent();
            _parishionerModel = new();
        }

        private void BtnSetSize_Click(object sender, EventArgs e)
        {
                  }

    }
}