using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class BalanceExceededEventArgs : EventArgs
    {
        public BalanceExceededEventArgs(Customer cus)
        {
            _balance = cus.Balance;
            _name = cus.Name;
        }
        public double _balance { get; private set; }
        public string _name { get; private set; }
    }
}
