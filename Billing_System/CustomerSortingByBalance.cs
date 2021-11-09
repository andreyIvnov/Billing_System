using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class CustomerSortingByBalance : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            double res = x.Balance - y.Balance;
            return (int)res;
        }
    }
}
