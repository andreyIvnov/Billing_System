using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class RegularCustomer:Customer
    {
        public RegularCustomer(string name)
            : base(name) { }
        public RegularCustomer(string name, int balance)
            : base(name, balance) { }

        public override void AddToBalance(double amount)
        {
            Balance += amount;
        }
    }
}
