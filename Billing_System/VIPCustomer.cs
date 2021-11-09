using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class VIPCustomer: Customer 
    {
        public VIPCustomer(string name): base(name) { }
        public VIPCustomer(string name, int balance) : base(name,balance) { }

        public override void AddToBalance(double amount)
        {
            Balance += (amount * 0.8);
        }
        public override string ToString()
        {
            string s = base.ToString();
            return "V.I.P=> "+s;
        }

    }
}
