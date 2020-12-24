using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    public class Withdrawal : Transaction
    {
        private IScreen _screen;
        private IKeyPad _keypad;
        private Account _account;
        private DispenseCash cashDispenser;

        public override string MenuName => "Withdrawal";

        public Withdrawal(IScreen screen,IKeyPad keypad,Account account)
        {
            _screen = screen;
            _keypad = keypad;
            _account = account;
            cashDispenser = new DispenseCash();
        }
        public override void Execute()
        {
            _screen.WriteLine("Enter the amount to withdraw");
            decimal amount = _keypad.ReadLine();
            if (cashDispenser.IsCashAvailable(amount))
            {
                _account.Withdraw(amount);
                cashDispenser.BalanceCashInDispenser(amount);
                _screen.WriteLine($"Your withdraw amount {amount:C} is  successful");
            }
            else
            {
                _screen.WriteLine($"No cash available.Try to reduce withdrawal amount");
            }
           
        }
    }

}
