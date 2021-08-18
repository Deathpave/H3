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
        private static bool _running = true;
        private static ATMMachine _atm = new ATMMachine();
        private static AccountManager _accountManager = new AccountManager();
        private static CardManager _cardManager = new CardManager();
        private static CreditCard _card;
        private static BankAccount _account;
        static void Main(string[] args)
        {
            Console.WriteLine("Fethcing you new bank account");
            _account = _accountManager.NewBankAccount();
            Console.WriteLine("\nEnter name to get a new creditcard");

            _card = _cardManager.NewCreditCard(Console.ReadLine(), _account.AccountNumber);
            Console.WriteLine("This is your pincode, dont forget it!\n" + _card.Password);
            Console.WriteLine("Press enter to continue");

            Console.ReadLine();
            Console.Clear();

            while (_running)
            {
                Console.Clear();
                Console.WriteLine("Select option\n0: Exit\n1: Balance\n2: Deposit\n3: Withdraw");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D0:
                        _running = false;
                        break;
                    case ConsoleKey.D1:
                        // pass
                        Console.WriteLine("Insert pincode");
                        int.TryParse(Console.ReadLine(), out int d1);
                        _atm.Balance(_card, d1);
                        break;
                    case ConsoleKey.D2:
                        // pass
                        Console.WriteLine("Insert pincode");
                        int.TryParse(Console.ReadLine(), out int d2);
                        Console.WriteLine("Insert amount");
                        // amount
                        int.TryParse(Console.ReadLine(), out int d2b);
                        _atm.Deposit(_card, d2, d2b);
                        break;
                    case ConsoleKey.D3:
                        // pass
                        Console.WriteLine("Insert pincode");
                        int.TryParse(Console.ReadLine(), out int d3);
                        // amount
                        Console.WriteLine("Insert Amount");
                        int.TryParse(Console.ReadLine(), out int d3b);
                        _atm.Withdraw(_card, d3, d3b);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
            Console.WriteLine("Thank you for using this atm");
            Console.ReadLine();

        }
    }
}
