using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLibrary
{
    class DispenseCash
    {
        public decimal CashInDispenser = 2000;
        public void BalanceCashInDispenser(decimal amount)
        {
            CashInDispenser -= amount;
        }
        public bool IsCashAvailable(decimal amount)
        {
            if (amount < CashInDispenser)
            {
                return true;
            }
            return false;
        }
    }
}
