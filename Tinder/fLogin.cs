namespace Tinder
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void llblCAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fCAccount fCreateAccount = new fCAccount();
            fCreateAccount.ShowDialog();
        }

        private void llblFPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fFPassword fFogetPassword = new fFPassword();
            fFogetPassword.ShowDialog();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isCheck = false;
            //txt check
            // code 
            //
            txtEmail.Text = "B@gmail.com";
            txtPassword.Text = "12345678";
            
            if (!isCheck)
            {
                User userCurrLogin = ExternalInterface.LogIn(txtEmail.Text, txtPassword.Text);
                if (userCurrLogin != null)
                {
                    fUInterface fUIntface = new fUInterface(userCurrLogin);
                    fUIntface.Show();
                }
                else
                {
                    MessageBox.Show("Wrong");
                }
            }
        }
    }
}