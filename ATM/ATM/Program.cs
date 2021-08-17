using ATM.DataModels;
using ATM.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        private static ATMMachine atm = new ATMMachine();
        private static AccountManager accountManager = new AccountManager();
        private static CardManager cardManager = new CardManager();
        private static CreditCard card;
        private static BankAccount account;
        static void Main(string[] args)
        {
            Console.WriteLine("Fethcing you new bank account");
            account = accountManager.NewBankAccount();
            Console.WriteLine("\nEnter name to get a new creditcard");

            card = cardManager.NewCreditCard(Console.ReadLine(), account.AccountNumber);
            Console.WriteLine("This is your pincode, dont forget it!\n" + card.Password);
            Console.WriteLine("Press enter to continue");

            Console.ReadLine();
            Console.Clear();

            Console.ReadLine();

        }
    }
}
