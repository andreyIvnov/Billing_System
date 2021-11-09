using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_System
{
    class CustomerSortingByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
