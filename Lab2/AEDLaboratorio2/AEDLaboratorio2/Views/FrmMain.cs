namespace AEDLaboratorio2.Views
{
    public partial class FrmMain : Form
    {
        private ParishionerView? _frmChurch;
        private FrmDentalClinic? _frmDentalClinic;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void MenuItemChurch_Click(object sender, EventArgs e)
        {
            _frmChurch = new() { Owner = this };
            _frmChurch.ShowDialog();
        }

        private void MenuItemDentalClinic_Click(object sender, EventArgs e)
        {
            _frmDentalClinic = new() { Owner = this };
            _frmDentalClinic.ShowDialog();
        }
    }
}