using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class RegisterForm : Form
    {
        List<Accounts> accountList;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void SetAccountList(List<Accounts> accountList)
        {
            this.accountList = accountList;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string confirmPassword = confirmPasswordInput.Text;
            bool existingAccount = false;

            if (agreeTnC.Checked == false)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "You need to agree to our terms and conditions";
                return;
            }

            foreach (Accounts accounts in accountList) 
            {
                if (username == accounts.Username)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "An account with this username already exists";
                    passwordInput.Text = "";
                    confirmPasswordInput.Text = "";
                    existingAccount = true;
                    return;
                }
            }

            if (existingAccount == false)
            {
                if (password.Equals(confirmPassword) && password != "" && confirmPassword != "")
                {
                    Accounts newAcc = new Accounts(username, password);
                    accountList.Add(newAcc);
                    label1.ForeColor = Color.ForestGreen;
                    label1.Text = "You have sucessfully registered an account";
                }

                else if (password == "" && confirmPassword == "")
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "You did not enter a password or confirm your password";
                }

                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "The passwords did not match";
                }
            }

            passwordInput.Text = "";
            confirmPasswordInput.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            usernameInput.Text = "";
            passwordInput.Text = "";
            confirmPasswordInput.Text = "";

            Hide();            
        }

        private void agreeTnC_CheckedChanged(object sender, EventArgs e)
        {
            agreeTnC.Checked = true;
        }
    }
}
