using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    public class Account
    {
        private int _accountNumber;
        private int _pin;
        private decimal _balance;
        
        public int AccountNumber
        {
            get
            {
                return _accountNumber; ;
            }
        }
        public int Pin
        {
            get
            {
                return _pin;
            }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        public Account(int accountNumber,int pin,decimal balance)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            _balance = balance;
        }
        public bool ValidatePin(int pin)
        {
            if(Pin==pin)
            {
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount < _balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            return false;
        }
        public static Account Fetch(int accountNumber,int pin)
        {
            foreach(Account account in _database)
            {
                if (accountNumber == account.AccountNumber)
                {
                    if (account.ValidatePin(pin))
                    {
                        return account;
                    }
                    else
                    {
                        return null;
                    }
                }
              
            }
            return null;
        }
        public static List<Account> _database = new List<Account>()
        {
            new Account(1234567,7777,1000m),
            new Account(9876543,6666,5000m)
        };
    }
}
