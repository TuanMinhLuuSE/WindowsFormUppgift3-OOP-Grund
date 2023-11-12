using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class Bankaccounts
    {
        public string BankaccountUsername { get; set; }
        public string BankaccountType { get; set; }
        int BankaccountBalance;

        public Bankaccounts(string bankaccountUsername, string bankaccountType, int bankaccountBalance)
        {
            this.BankaccountUsername = bankaccountUsername;
            this.BankaccountType = bankaccountType;
            this.BankaccountBalance = bankaccountBalance;
        }

        public void AddBalance(int depositAmount)
        {
            BankaccountBalance += depositAmount;
        }

        public void RemoveBalance()
        {

        }
    }
}
