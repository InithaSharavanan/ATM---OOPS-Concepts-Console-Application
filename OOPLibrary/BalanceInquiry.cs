using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    public class BalanceInquiry : Transaction
    {
        private IScreen _screen;
        private Account _account;
        public BalanceInquiry(IScreen screen,Account account)
        {
            _screen = screen;
            _account = account;
        }

        public override string MenuName => "Balance Inquiry";

        public override void Execute()
        {
            _screen.WriteLine($"Your balance amount : {_account.Balance:C}");
        }
    }
}
