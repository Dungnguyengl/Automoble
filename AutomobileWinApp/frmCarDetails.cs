namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK", "Alert!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel!", "Alert!");
        }
    }
}
