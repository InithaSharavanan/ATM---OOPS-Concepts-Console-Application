using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    public class ATM
    {
        private readonly IScreen _screen;
        private readonly IKeyPad _keypad;
        private Account _account;
        public ATM(IScreen screen,IKeyPad keypad)
        {
            _screen = screen;
            _keypad = keypad;
        }
        public void Start()
        {
            while (true)
            {
                _screen.WriteLine("Welcome!!!\n Enter the account number");
                int accountNum = _keypad.ReadLine();
                _screen.WriteLine("Enter the Pin");
                int pin = _keypad.Read(4);
                _account = Account.Fetch(accountNum, pin);
                if (_account != null)
                {
                    Menu();
                    _screen.WriteLine($"Thank you for  visiting our ATM..!");
                }
            }
            
        }
        public void Menu()
        {
            Transaction[] transactions = new Transaction[]
            {
                new BalanceInquiry(_screen,_account),
                new Deposit(_screen,_keypad,_account),
                new Withdrawal(_screen,_keypad,_account)
            };
            int choice = 5;
            while (choice>0)
            {
                Console.WriteLine("Main Menu");
                for (int i = 0; i < transactions.Length; i++)
                {
                    _screen.WriteLine($"{i + 1}   {transactions[i].MenuName}");
                }
                _screen.WriteLine($"0   Exit");
                choice = _keypad.Read(1);
                if (choice == 0)
                {
                    _account = null;
                }
                else if (choice > 0 && choice <= transactions.Length)
                {
                    PerformTransaction(choice, transactions);
                }
            }
           

        }
        public void PerformTransaction(int choice,Transaction[] transactions)
        {
            Transaction transaction = transactions[choice - 1];
            transaction.Execute();
        }

    }
}

