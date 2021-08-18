using ATM.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Managers
{
    public class AccountManager
    {
        private static List<BankAccount> _bankAccounts = new List<BankAccount>();

        public BankAccount NewBankAccount()
        {
            Random random = new Random();
            BankAccount bankAccount = new BankAccount(random.Next(10000000, 99999999));
            _bankAccounts.Add(bankAccount);
            return bankAccount;
        }

        public static List<BankAccount> GetAccounts()
        {
            return _bankAccounts;
        }
    }
}
