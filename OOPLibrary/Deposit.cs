using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    class Deposit : Transaction
    {
        private IScreen _screen;
        private IKeyPad _keypad;
        private Account _account;
        private DepositSlot depositSlot;
        public Deposit(IScreen screen,IKeyPad keypad,Account account)
        {
            _screen = screen;
            _keypad = keypad;
            _account = account;
            depositSlot = new DepositSlot();
        }
        public override string MenuName => "Deposit";

        public override void Execute()
        {
            _screen.WriteLine($"Enter the amount to deposit");
            decimal amount = _keypad.ReadLine();
            if (depositSlot.IsDepositEnvelopeReceived())
            {
                _account.Deposit(amount);
                _screen.WriteLine($"Deposit Amount {amount:C} is successful!!");
            }
            else
            {
                _screen.WriteLine($"You did not insert the deposit envelope.Transaction cancelled");
            }
           
        }
    }
}
