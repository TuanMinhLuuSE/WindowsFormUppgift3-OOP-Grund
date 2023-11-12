namespace LoginApp
{
    public partial class LoginForm : Form
    {
        LoggedInForm loggedInForm = new LoggedInForm();
        List<Accounts> accountList = new List<Accounts>();

        Accounts acc1 = new Accounts("Admin", "Password");
        public LoginForm()
        {
            InitializeComponent();           
            accountList.Add(acc1);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text;
            string password = loginPassword.Text;

            foreach (Accounts accounts in accountList)
            {
                if (username == accounts.Username && password == accounts.Password)
                {
                    loginPassword.Text = "";                   
                    loggedInForm.Show();
                    loggedInForm.currectUser = accounts.Username;
                    loggedInForm.SetAccountList(accountList);
                    loggedInForm.label1.Text = $"Welcome {accounts.Username}!";
                    return;
                }
            }

            loginPassword.Text = "";
            label1.ForeColor = Color.Red;
            label1.Text = "Your username or password was incorrect";
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.SetAccountList(accountList);
            registerForm.Show();
        }
    }
}