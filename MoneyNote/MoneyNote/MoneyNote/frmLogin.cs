namespace MoneyNote
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
        }

        private void btnEye2_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void btnEye2_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
