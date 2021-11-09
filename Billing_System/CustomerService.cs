using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class CustomerService
    {
        public CustomerService(BillingSystem bs)
        {
            bs.BalanceExceeded += BalanceExceeded_ForCustomerService;
        }

        private void BalanceExceeded_ForCustomerService(object sender, BalanceExceededEventArgs arg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  Hello {arg._name}, here a Customer Service we are check for you if you'r exceeded is a mistake"); ;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
