using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class AccountingClerk: CFO
    {
        public AccountingClerk(BillingSystem bs)
        {
            bs.BalanceExceeded += Bs_BalanceExceeded;
        }
        private void Bs_BalanceExceeded(object sender, BalanceExceededEventArgs arg)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tThe Account Clerk said it to the to he's CFO!");
            Knowing();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
