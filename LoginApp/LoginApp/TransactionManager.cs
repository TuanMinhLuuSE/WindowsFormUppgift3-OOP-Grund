using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    public class TransactionManager
    {
        List<Bankaccounts> bankaccountList = new List<Bankaccounts>();

        public List<Bankaccounts> GetBankaccountList() { return bankaccountList; }

        public void Withdraw()
        {

        }

        public void Deposit(string currentUser, string bankaccountTypeInput, int depositAmount)
        {
            foreach (Bankaccounts bankaccount in bankaccountList) 
            {
                if (bankaccount.BankaccountUsername == currentUser && bankaccount.BankaccountType == bankaccountTypeInput)
                {
                    bankaccount.AddBalance(depositAmount);
                }
            }
        }

        public void Transfer()
        {
            
        }

        public void OpenAccount(string bankaccountTypeInput, int depositIntoNewBankaccount, string currentUser)
        {
            Bankaccounts newBankaccount = new Bankaccounts(currentUser, bankaccountTypeInput, 0);
            bankaccountList.Add(newBankaccount);
            Deposit(currentUser, bankaccountTypeInput, depositIntoNewBankaccount);
        }
    }
}
