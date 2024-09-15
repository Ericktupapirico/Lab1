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
            var (result, message) = _parishionerModel.InitializeArray(Convert.ToInt32(TxtNumSize.Value));
            if (!result)
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}