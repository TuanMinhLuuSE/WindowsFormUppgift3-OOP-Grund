using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginApp
{
    public partial class LoggedInForm : Form
    {
        TransactionManager transactionManager = new TransactionManager();
        List<Accounts> accountList;
        public string currectUser;

        public LoggedInForm()
        {
            InitializeComponent();
            changePasswordPanel.Visible = false;
            withdrawPanel.Visible = false;
            openAccountPanel.Visible = false;
        }

        public void SetAccountList(List <Accounts> accountList)
        {
            this.accountList = accountList;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            changePasswordPanel.Visible = false;
            withdrawPanel.Visible = false;
            openAccountPanel.Visible = false;
            Hide();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {          
            bankaccountPicker.Items.Clear();
            List <Bankaccounts> bankaccountList = transactionManager.GetBankaccountList();
            
            foreach (Bankaccounts bankaccounts in bankaccountList)
            {
                if (bankaccounts.BankaccountUsername == currectUser)
                {
                    bankaccountPicker.Items.Add(bankaccounts.BankaccountType);
                }
            }

            withdrawPanel.Location = new Point(238, 0);
            withdrawPanel.BringToFront();
            withdrawPanel.Visible = true;           
        }

        private void depositButton_Click(object sender, EventArgs e)
        {

        }

        private void transferButton_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePasswordPanel.Location = new Point(238, 0);
            changePasswordPanel.BringToFront();
            changePasswordPanel.Visible = true;
        }

        private void changePasswordPanelButton_Click(object sender, EventArgs e)
        {
            string oldPasswordInput = oldPassword.Text;
            string newPasswordInput = newPassword.Text;
            string newPassword2Input = newPassword2.Text;

            if (newPasswordInput == newPassword2Input)
            {
                foreach (Accounts accounts in accountList)
                {
                    if (accounts.Password == oldPasswordInput && accounts.Username == currectUser)
                    {
                        accounts.Password = newPasswordInput;
                        label2.ForeColor = Color.ForestGreen;
                        label2.Text = "You have sucessfully changed your password";
                        return;
                    }
                }
                label2.ForeColor = Color.Red;
                label2.Text = "Your current password is incorrect";
            }

            else if (newPasswordInput == "" && newPassword2Input == "")
            {
                label2.ForeColor = Color.Red;
                label2.Text = "You did not enter your new password or confirm your new password";
            }

            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "The passwords did not match";
            }

            oldPassword.Text = "";
            newPassword.Text = "";
            newPassword2.Text = "";
        }

        private void agreeTnCOpenAccount_CheckedChanged(object sender, EventArgs e)
        {
            agreeTnCOpenAccount.Checked = true;
        }

        private void openAccountPanelButton_Click(object sender, EventArgs e)
        {
            if (agreeTnCOpenAccount.Checked == false)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "You need to agree to our terms and conditions";
                return;
            }

            try
            {
                string bankAccountTypeInput = chooseBankaccountTypeBox.Text;
                int depositIntoNewBankaccount = Convert.ToInt32(openAccountDepositInput.Text);
                transactionManager.OpenAccount(bankAccountTypeInput, depositIntoNewBankaccount, currectUser);

                //bankaccountPicker.Items.Add(bankAccountTypeInput);
                label3.ForeColor = Color.ForestGreen;
                label3.Text = $"You have successfully open a {bankAccountTypeInput.ToLower()}";
            }
            catch 
            {
                label3.ForeColor = Color.Red;
                label3.Text = "You did not enter a number into the depositamount.";
            }
        }

        private void openBankaccountButton_Click(object sender, EventArgs e)
        {
            openAccountPanel.Location = new Point(238, 0);
            openAccountPanel.BringToFront();
            openAccountPanel.Visible = true;
        }
    }
}
